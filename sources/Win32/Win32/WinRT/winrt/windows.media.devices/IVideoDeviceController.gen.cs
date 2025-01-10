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

[Guid("99555575-2E2E-40B8-B6C7-F82D10013210")]
[NativeTypeName("struct IVideoDeviceController : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVideoDeviceController : IVideoDeviceController.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVideoDeviceController));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVideoDeviceController, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IVideoDeviceController, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVideoDeviceController, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IVideoDeviceController, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IVideoDeviceController, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IVideoDeviceController, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Brightness(
        [NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")]
            IMediaDeviceControl* value
    )
    {
        return (
            (delegate* unmanaged<IVideoDeviceController, IMediaDeviceControl*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Contrast(
        [NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")]
            IMediaDeviceControl* value
    )
    {
        return (
            (delegate* unmanaged<IVideoDeviceController, IMediaDeviceControl*, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Hue(
        [NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")]
            IMediaDeviceControl* value
    )
    {
        return (
            (delegate* unmanaged<IVideoDeviceController, IMediaDeviceControl*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_WhiteBalance(
        [NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")]
            IMediaDeviceControl* value
    )
    {
        return (
            (delegate* unmanaged<IVideoDeviceController, IMediaDeviceControl*, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_BacklightCompensation(
        [NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")]
            IMediaDeviceControl* value
    )
    {
        return (
            (delegate* unmanaged<IVideoDeviceController, IMediaDeviceControl*, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Pan(
        [NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")]
            IMediaDeviceControl* value
    )
    {
        return (
            (delegate* unmanaged<IVideoDeviceController, IMediaDeviceControl*, int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Tilt(
        [NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")]
            IMediaDeviceControl* value
    )
    {
        return (
            (delegate* unmanaged<IVideoDeviceController, IMediaDeviceControl*, int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Zoom(
        [NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")]
            IMediaDeviceControl* value
    )
    {
        return (
            (delegate* unmanaged<IVideoDeviceController, IMediaDeviceControl*, int>)((*lpVtbl)[13])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Roll(
        [NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")]
            IMediaDeviceControl* value
    )
    {
        return (
            (delegate* unmanaged<IVideoDeviceController, IMediaDeviceControl*, int>)((*lpVtbl)[14])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Exposure(
        [NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")]
            IMediaDeviceControl* value
    )
    {
        return (
            (delegate* unmanaged<IVideoDeviceController, IMediaDeviceControl*, int>)((*lpVtbl)[15])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Focus(
        [NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")]
            IMediaDeviceControl* value
    )
    {
        return (
            (delegate* unmanaged<IVideoDeviceController, IMediaDeviceControl*, int>)((*lpVtbl)[16])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT TrySetPowerlineFrequency(
        [NativeTypeName("ABI::Windows::Media::Capture::PowerlineFrequency")]
            PowerlineFrequency value,
        [NativeTypeName("boolean *")] byte* succeeded
    )
    {
        return (
            (delegate* unmanaged<IVideoDeviceController, PowerlineFrequency, byte*, int>)(
                (*lpVtbl)[17]
            )
        )(this, value, succeeded);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT TryGetPowerlineFrequency(
        [NativeTypeName("ABI::Windows::Media::Capture::PowerlineFrequency *")]
            PowerlineFrequency* value,
        [NativeTypeName("boolean *")] byte* succeeded
    )
    {
        return (
            (delegate* unmanaged<IVideoDeviceController, PowerlineFrequency*, byte*, int>)(
                (*lpVtbl)[18]
            )
        )(this, value, succeeded);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Brightness(
            [NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")]
                IMediaDeviceControl* value
        );

        [VtblIndex(7)]
        HRESULT get_Contrast(
            [NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")]
                IMediaDeviceControl* value
        );

        [VtblIndex(8)]
        HRESULT get_Hue(
            [NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")]
                IMediaDeviceControl* value
        );

        [VtblIndex(9)]
        HRESULT get_WhiteBalance(
            [NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")]
                IMediaDeviceControl* value
        );

        [VtblIndex(10)]
        HRESULT get_BacklightCompensation(
            [NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")]
                IMediaDeviceControl* value
        );

        [VtblIndex(11)]
        HRESULT get_Pan(
            [NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")]
                IMediaDeviceControl* value
        );

        [VtblIndex(12)]
        HRESULT get_Tilt(
            [NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")]
                IMediaDeviceControl* value
        );

        [VtblIndex(13)]
        HRESULT get_Zoom(
            [NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")]
                IMediaDeviceControl* value
        );

        [VtblIndex(14)]
        HRESULT get_Roll(
            [NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")]
                IMediaDeviceControl* value
        );

        [VtblIndex(15)]
        HRESULT get_Exposure(
            [NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")]
                IMediaDeviceControl* value
        );

        [VtblIndex(16)]
        HRESULT get_Focus(
            [NativeTypeName("ABI::Windows::Media::Devices::IMediaDeviceControl **")]
                IMediaDeviceControl* value
        );

        [VtblIndex(17)]
        HRESULT TrySetPowerlineFrequency(
            [NativeTypeName("ABI::Windows::Media::Capture::PowerlineFrequency")]
                PowerlineFrequency value,
            [NativeTypeName("boolean *")] byte* succeeded
        );

        [VtblIndex(18)]
        HRESULT TryGetPowerlineFrequency(
            [NativeTypeName("ABI::Windows::Media::Capture::PowerlineFrequency *")]
                PowerlineFrequency* value,
            [NativeTypeName("boolean *")] byte* succeeded
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
            "HRESULT (ABI::Windows::Media::Devices::IMediaDeviceControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaDeviceControl*, int> get_Brightness;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::IMediaDeviceControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaDeviceControl*, int> get_Contrast;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::IMediaDeviceControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaDeviceControl*, int> get_Hue;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::IMediaDeviceControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaDeviceControl*, int> get_WhiteBalance;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::IMediaDeviceControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaDeviceControl*, int> get_BacklightCompensation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::IMediaDeviceControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaDeviceControl*, int> get_Pan;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::IMediaDeviceControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaDeviceControl*, int> get_Tilt;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::IMediaDeviceControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaDeviceControl*, int> get_Zoom;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::IMediaDeviceControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaDeviceControl*, int> get_Roll;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::IMediaDeviceControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaDeviceControl*, int> get_Exposure;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::IMediaDeviceControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaDeviceControl*, int> get_Focus;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::PowerlineFrequency, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PowerlineFrequency, byte*, int> TrySetPowerlineFrequency;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::PowerlineFrequency *, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            PowerlineFrequency*,
            byte*,
            int> TryGetPowerlineFrequency;
    }

    /// <summary>Initializes a new instance of the <see cref = "IVideoDeviceController"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IVideoDeviceController(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IVideoDeviceController"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IVideoDeviceController(Silk.NET.WinRT.IInspectable value)
    {
        return new IVideoDeviceController(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVideoDeviceController"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IVideoDeviceController"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IVideoDeviceController value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IVideoDeviceController"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IVideoDeviceController(Silk.NET.Windows.IUnknown value)
    {
        return new IVideoDeviceController(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVideoDeviceController"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IVideoDeviceController"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IVideoDeviceController value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
