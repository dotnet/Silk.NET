// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("6374EA4C-1B3B-4001-94D9-DD225330FA40")]
[NativeTypeName("struct IAudioStateMonitorStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioStateMonitorStatics
    : IAudioStateMonitorStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioStateMonitorStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioStateMonitorStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAudioStateMonitorStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioStateMonitorStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAudioStateMonitorStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAudioStateMonitorStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAudioStateMonitorStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateForRenderMonitoring(
        [NativeTypeName("ABI::Windows::Media::Audio::IAudioStateMonitor **")]
            IAudioStateMonitor* result
    )
    {
        return (
            (delegate* unmanaged<IAudioStateMonitorStatics, IAudioStateMonitor*, int>)((*lpVtbl)[6])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateForRenderMonitoringWithCategory(
        [NativeTypeName("ABI::Windows::Media::Render::AudioRenderCategory")]
            AudioRenderCategory category,
        [NativeTypeName("ABI::Windows::Media::Audio::IAudioStateMonitor **")]
            IAudioStateMonitor* result
    )
    {
        return (
            (delegate* unmanaged<
                IAudioStateMonitorStatics,
                AudioRenderCategory,
                IAudioStateMonitor*,
                int>)((*lpVtbl)[7])
        )(this, category, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateForRenderMonitoringWithCategoryAndDeviceRole(
        [NativeTypeName("ABI::Windows::Media::Render::AudioRenderCategory")]
            AudioRenderCategory category,
        [NativeTypeName("ABI::Windows::Media::Devices::AudioDeviceRole")] AudioDeviceRole role,
        [NativeTypeName("ABI::Windows::Media::Audio::IAudioStateMonitor **")]
            IAudioStateMonitor* result
    )
    {
        return (
            (delegate* unmanaged<
                IAudioStateMonitorStatics,
                AudioRenderCategory,
                AudioDeviceRole,
                IAudioStateMonitor*,
                int>)((*lpVtbl)[8])
        )(this, category, role, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateForRenderMonitoringWithCategoryAndDeviceId(
        [NativeTypeName("ABI::Windows::Media::Render::AudioRenderCategory")]
            AudioRenderCategory category,
        HSTRING deviceId,
        [NativeTypeName("ABI::Windows::Media::Audio::IAudioStateMonitor **")]
            IAudioStateMonitor* result
    )
    {
        return (
            (delegate* unmanaged<
                IAudioStateMonitorStatics,
                AudioRenderCategory,
                HSTRING,
                IAudioStateMonitor*,
                int>)((*lpVtbl)[9])
        )(this, category, deviceId, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateForCaptureMonitoring(
        [NativeTypeName("ABI::Windows::Media::Audio::IAudioStateMonitor **")]
            IAudioStateMonitor* result
    )
    {
        return (
            (delegate* unmanaged<IAudioStateMonitorStatics, IAudioStateMonitor*, int>)(
                (*lpVtbl)[10]
            )
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateForCaptureMonitoringWithCategory(
        [NativeTypeName("ABI::Windows::Media::Capture::MediaCategory")] MediaCategory category,
        [NativeTypeName("ABI::Windows::Media::Audio::IAudioStateMonitor **")]
            IAudioStateMonitor* result
    )
    {
        return (
            (delegate* unmanaged<
                IAudioStateMonitorStatics,
                MediaCategory,
                IAudioStateMonitor*,
                int>)((*lpVtbl)[11])
        )(this, category, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateForCaptureMonitoringWithCategoryAndDeviceRole(
        [NativeTypeName("ABI::Windows::Media::Capture::MediaCategory")] MediaCategory category,
        [NativeTypeName("ABI::Windows::Media::Devices::AudioDeviceRole")] AudioDeviceRole role,
        [NativeTypeName("ABI::Windows::Media::Audio::IAudioStateMonitor **")]
            IAudioStateMonitor* result
    )
    {
        return (
            (delegate* unmanaged<
                IAudioStateMonitorStatics,
                MediaCategory,
                AudioDeviceRole,
                IAudioStateMonitor*,
                int>)((*lpVtbl)[12])
        )(this, category, role, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateForCaptureMonitoringWithCategoryAndDeviceId(
        [NativeTypeName("ABI::Windows::Media::Capture::MediaCategory")] MediaCategory category,
        HSTRING deviceId,
        [NativeTypeName("ABI::Windows::Media::Audio::IAudioStateMonitor **")]
            IAudioStateMonitor* result
    )
    {
        return (
            (delegate* unmanaged<
                IAudioStateMonitorStatics,
                MediaCategory,
                HSTRING,
                IAudioStateMonitor*,
                int>)((*lpVtbl)[13])
        )(this, category, deviceId, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateForRenderMonitoring(
            [NativeTypeName("ABI::Windows::Media::Audio::IAudioStateMonitor **")]
                IAudioStateMonitor* result
        );

        [VtblIndex(7)]
        HRESULT CreateForRenderMonitoringWithCategory(
            [NativeTypeName("ABI::Windows::Media::Render::AudioRenderCategory")]
                AudioRenderCategory category,
            [NativeTypeName("ABI::Windows::Media::Audio::IAudioStateMonitor **")]
                IAudioStateMonitor* result
        );

        [VtblIndex(8)]
        HRESULT CreateForRenderMonitoringWithCategoryAndDeviceRole(
            [NativeTypeName("ABI::Windows::Media::Render::AudioRenderCategory")]
                AudioRenderCategory category,
            [NativeTypeName("ABI::Windows::Media::Devices::AudioDeviceRole")] AudioDeviceRole role,
            [NativeTypeName("ABI::Windows::Media::Audio::IAudioStateMonitor **")]
                IAudioStateMonitor* result
        );

        [VtblIndex(9)]
        HRESULT CreateForRenderMonitoringWithCategoryAndDeviceId(
            [NativeTypeName("ABI::Windows::Media::Render::AudioRenderCategory")]
                AudioRenderCategory category,
            HSTRING deviceId,
            [NativeTypeName("ABI::Windows::Media::Audio::IAudioStateMonitor **")]
                IAudioStateMonitor* result
        );

        [VtblIndex(10)]
        HRESULT CreateForCaptureMonitoring(
            [NativeTypeName("ABI::Windows::Media::Audio::IAudioStateMonitor **")]
                IAudioStateMonitor* result
        );

        [VtblIndex(11)]
        HRESULT CreateForCaptureMonitoringWithCategory(
            [NativeTypeName("ABI::Windows::Media::Capture::MediaCategory")] MediaCategory category,
            [NativeTypeName("ABI::Windows::Media::Audio::IAudioStateMonitor **")]
                IAudioStateMonitor* result
        );

        [VtblIndex(12)]
        HRESULT CreateForCaptureMonitoringWithCategoryAndDeviceRole(
            [NativeTypeName("ABI::Windows::Media::Capture::MediaCategory")] MediaCategory category,
            [NativeTypeName("ABI::Windows::Media::Devices::AudioDeviceRole")] AudioDeviceRole role,
            [NativeTypeName("ABI::Windows::Media::Audio::IAudioStateMonitor **")]
                IAudioStateMonitor* result
        );

        [VtblIndex(13)]
        HRESULT CreateForCaptureMonitoringWithCategoryAndDeviceId(
            [NativeTypeName("ABI::Windows::Media::Capture::MediaCategory")] MediaCategory category,
            HSTRING deviceId,
            [NativeTypeName("ABI::Windows::Media::Audio::IAudioStateMonitor **")]
                IAudioStateMonitor* result
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
            "HRESULT (ABI::Windows::Media::Audio::IAudioStateMonitor **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAudioStateMonitor*, int> CreateForRenderMonitoring;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Render::AudioRenderCategory, ABI::Windows::Media::Audio::IAudioStateMonitor **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AudioRenderCategory,
            IAudioStateMonitor*,
            int> CreateForRenderMonitoringWithCategory;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Render::AudioRenderCategory, ABI::Windows::Media::Devices::AudioDeviceRole, ABI::Windows::Media::Audio::IAudioStateMonitor **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AudioRenderCategory,
            AudioDeviceRole,
            IAudioStateMonitor*,
            int> CreateForRenderMonitoringWithCategoryAndDeviceRole;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Render::AudioRenderCategory, HSTRING, ABI::Windows::Media::Audio::IAudioStateMonitor **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AudioRenderCategory,
            HSTRING,
            IAudioStateMonitor*,
            int> CreateForRenderMonitoringWithCategoryAndDeviceId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Audio::IAudioStateMonitor **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAudioStateMonitor*, int> CreateForCaptureMonitoring;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::MediaCategory, ABI::Windows::Media::Audio::IAudioStateMonitor **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MediaCategory,
            IAudioStateMonitor*,
            int> CreateForCaptureMonitoringWithCategory;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::MediaCategory, ABI::Windows::Media::Devices::AudioDeviceRole, ABI::Windows::Media::Audio::IAudioStateMonitor **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MediaCategory,
            AudioDeviceRole,
            IAudioStateMonitor*,
            int> CreateForCaptureMonitoringWithCategoryAndDeviceRole;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::MediaCategory, HSTRING, ABI::Windows::Media::Audio::IAudioStateMonitor **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MediaCategory,
            HSTRING,
            IAudioStateMonitor*,
            int> CreateForCaptureMonitoringWithCategoryAndDeviceId;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioStateMonitorStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioStateMonitorStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAudioStateMonitorStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAudioStateMonitorStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IAudioStateMonitorStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioStateMonitorStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioStateMonitorStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAudioStateMonitorStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioStateMonitorStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioStateMonitorStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioStateMonitorStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioStateMonitorStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioStateMonitorStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioStateMonitorStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
