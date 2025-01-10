// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("64E92D1F-A28D-425A-B84F-E568335FF24E")]
[NativeTypeName("struct ICameraCaptureUIVideoCaptureSettings : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICameraCaptureUIVideoCaptureSettings
    : ICameraCaptureUIVideoCaptureSettings.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICameraCaptureUIVideoCaptureSettings));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ICameraCaptureUIVideoCaptureSettings, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICameraCaptureUIVideoCaptureSettings, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICameraCaptureUIVideoCaptureSettings, uint>)((*lpVtbl)[2]))(
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
            (delegate* unmanaged<ICameraCaptureUIVideoCaptureSettings, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<ICameraCaptureUIVideoCaptureSettings, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ICameraCaptureUIVideoCaptureSettings, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Format(
        [NativeTypeName("ABI::Windows::Media::Capture::CameraCaptureUIVideoFormat *")]
            CameraCaptureUIVideoFormat* value
    )
    {
        return (
            (delegate* unmanaged<
                ICameraCaptureUIVideoCaptureSettings,
                CameraCaptureUIVideoFormat*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Format(
        [NativeTypeName("ABI::Windows::Media::Capture::CameraCaptureUIVideoFormat")]
            CameraCaptureUIVideoFormat value
    )
    {
        return (
            (delegate* unmanaged<
                ICameraCaptureUIVideoCaptureSettings,
                CameraCaptureUIVideoFormat,
                int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MaxResolution(
        [NativeTypeName("ABI::Windows::Media::Capture::CameraCaptureUIMaxVideoResolution *")]
            CameraCaptureUIMaxVideoResolution* value
    )
    {
        return (
            (delegate* unmanaged<
                ICameraCaptureUIVideoCaptureSettings,
                CameraCaptureUIMaxVideoResolution*,
                int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_MaxResolution(
        [NativeTypeName("ABI::Windows::Media::Capture::CameraCaptureUIMaxVideoResolution")]
            CameraCaptureUIMaxVideoResolution value
    )
    {
        return (
            (delegate* unmanaged<
                ICameraCaptureUIVideoCaptureSettings,
                CameraCaptureUIMaxVideoResolution,
                int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MaxDurationInSeconds(float* value)
    {
        return (
            (delegate* unmanaged<ICameraCaptureUIVideoCaptureSettings, float*, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_MaxDurationInSeconds(float value)
    {
        return (
            (delegate* unmanaged<ICameraCaptureUIVideoCaptureSettings, float, int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_AllowTrimming([NativeTypeName("boolean *")] byte* value)
    {
        return (
            (delegate* unmanaged<ICameraCaptureUIVideoCaptureSettings, byte*, int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_AllowTrimming([NativeTypeName("boolean")] byte value)
    {
        return (
            (delegate* unmanaged<ICameraCaptureUIVideoCaptureSettings, byte, int>)((*lpVtbl)[13])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Format(
            [NativeTypeName("ABI::Windows::Media::Capture::CameraCaptureUIVideoFormat *")]
                CameraCaptureUIVideoFormat* value
        );

        [VtblIndex(7)]
        HRESULT put_Format(
            [NativeTypeName("ABI::Windows::Media::Capture::CameraCaptureUIVideoFormat")]
                CameraCaptureUIVideoFormat value
        );

        [VtblIndex(8)]
        HRESULT get_MaxResolution(
            [NativeTypeName("ABI::Windows::Media::Capture::CameraCaptureUIMaxVideoResolution *")]
                CameraCaptureUIMaxVideoResolution* value
        );

        [VtblIndex(9)]
        HRESULT put_MaxResolution(
            [NativeTypeName("ABI::Windows::Media::Capture::CameraCaptureUIMaxVideoResolution")]
                CameraCaptureUIMaxVideoResolution value
        );

        [VtblIndex(10)]
        HRESULT get_MaxDurationInSeconds(float* value);

        [VtblIndex(11)]
        HRESULT put_MaxDurationInSeconds(float value);

        [VtblIndex(12)]
        HRESULT get_AllowTrimming([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT put_AllowTrimming([NativeTypeName("boolean")] byte value);
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
            "HRESULT (ABI::Windows::Media::Capture::CameraCaptureUIVideoFormat *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CameraCaptureUIVideoFormat*, int> get_Format;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::CameraCaptureUIVideoFormat) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CameraCaptureUIVideoFormat, int> put_Format;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::CameraCaptureUIMaxVideoResolution *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CameraCaptureUIMaxVideoResolution*,
            int> get_MaxResolution;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::CameraCaptureUIMaxVideoResolution) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CameraCaptureUIMaxVideoResolution,
            int> put_MaxResolution;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_MaxDurationInSeconds;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_MaxDurationInSeconds;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_AllowTrimming;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_AllowTrimming;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICameraCaptureUIVideoCaptureSettings"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICameraCaptureUIVideoCaptureSettings(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICameraCaptureUIVideoCaptureSettings"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICameraCaptureUIVideoCaptureSettings(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ICameraCaptureUIVideoCaptureSettings(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICameraCaptureUIVideoCaptureSettings"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICameraCaptureUIVideoCaptureSettings"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ICameraCaptureUIVideoCaptureSettings value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICameraCaptureUIVideoCaptureSettings"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICameraCaptureUIVideoCaptureSettings(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ICameraCaptureUIVideoCaptureSettings(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICameraCaptureUIVideoCaptureSettings"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICameraCaptureUIVideoCaptureSettings"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ICameraCaptureUIVideoCaptureSettings value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
