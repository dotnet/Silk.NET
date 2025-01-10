// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.devices.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("A8FFAE60-4E9E-4377-A789-E24C4AE7E544")]
[NativeTypeName("struct IFrameControlCapabilities : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFrameControlCapabilities
    : IFrameControlCapabilities.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFrameControlCapabilities));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFrameControlCapabilities, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IFrameControlCapabilities, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFrameControlCapabilities, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IFrameControlCapabilities, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IFrameControlCapabilities, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IFrameControlCapabilities, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Exposure(
        [NativeTypeName("ABI::Windows::Media::Devices::Core::IFrameExposureCapabilities **")]
            IFrameExposureCapabilities* value
    )
    {
        return (
            (delegate* unmanaged<IFrameControlCapabilities, IFrameExposureCapabilities*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ExposureCompensation(
        [NativeTypeName(
            "ABI::Windows::Media::Devices::Core::IFrameExposureCompensationCapabilities **"
        )]
            IFrameExposureCompensationCapabilities* value
    )
    {
        return (
            (delegate* unmanaged<
                IFrameControlCapabilities,
                IFrameExposureCompensationCapabilities*,
                int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsoSpeed(
        [NativeTypeName("ABI::Windows::Media::Devices::Core::IFrameIsoSpeedCapabilities **")]
            IFrameIsoSpeedCapabilities* value
    )
    {
        return (
            (delegate* unmanaged<IFrameControlCapabilities, IFrameIsoSpeedCapabilities*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Focus(
        [NativeTypeName("ABI::Windows::Media::Devices::Core::IFrameFocusCapabilities **")]
            IFrameFocusCapabilities* value
    )
    {
        return (
            (delegate* unmanaged<IFrameControlCapabilities, IFrameFocusCapabilities*, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_PhotoConfirmationSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IFrameControlCapabilities, byte*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Exposure(
            [NativeTypeName("ABI::Windows::Media::Devices::Core::IFrameExposureCapabilities **")]
                IFrameExposureCapabilities* value
        );

        [VtblIndex(7)]
        HRESULT get_ExposureCompensation(
            [NativeTypeName(
                "ABI::Windows::Media::Devices::Core::IFrameExposureCompensationCapabilities **"
            )]
                IFrameExposureCompensationCapabilities* value
        );

        [VtblIndex(8)]
        HRESULT get_IsoSpeed(
            [NativeTypeName("ABI::Windows::Media::Devices::Core::IFrameIsoSpeedCapabilities **")]
                IFrameIsoSpeedCapabilities* value
        );

        [VtblIndex(9)]
        HRESULT get_Focus(
            [NativeTypeName("ABI::Windows::Media::Devices::Core::IFrameFocusCapabilities **")]
                IFrameFocusCapabilities* value
        );

        [VtblIndex(10)]
        HRESULT get_PhotoConfirmationSupported([NativeTypeName("boolean *")] byte* value);
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
            "HRESULT (ABI::Windows::Media::Devices::Core::IFrameExposureCapabilities **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IFrameExposureCapabilities*, int> get_Exposure;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::Core::IFrameExposureCompensationCapabilities **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IFrameExposureCompensationCapabilities*,
            int> get_ExposureCompensation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::Core::IFrameIsoSpeedCapabilities **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IFrameIsoSpeedCapabilities*, int> get_IsoSpeed;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::Core::IFrameFocusCapabilities **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IFrameFocusCapabilities*, int> get_Focus;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_PhotoConfirmationSupported;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFrameControlCapabilities"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFrameControlCapabilities(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IFrameControlCapabilities"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IFrameControlCapabilities(Silk.NET.WinRT.IInspectable value)
    {
        return new IFrameControlCapabilities(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFrameControlCapabilities"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IFrameControlCapabilities"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IFrameControlCapabilities value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFrameControlCapabilities"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFrameControlCapabilities(Silk.NET.Windows.IUnknown value)
    {
        return new IFrameControlCapabilities(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFrameControlCapabilities"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFrameControlCapabilities"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFrameControlCapabilities value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
