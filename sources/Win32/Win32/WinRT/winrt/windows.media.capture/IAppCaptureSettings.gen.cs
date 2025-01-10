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

[Guid("14683A86-8807-48D3-883A-970EE4532A39")]
[NativeTypeName("struct IAppCaptureSettings : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppCaptureSettings : IAppCaptureSettings.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppCaptureSettings));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppCaptureSettings, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppCaptureSettings, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppCaptureSettings, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAppCaptureSettings, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAppCaptureSettings, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAppCaptureSettings, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_AppCaptureDestinationFolder(
        [NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder value
    )
    {
        return ((delegate* unmanaged<IAppCaptureSettings, IStorageFolder, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AppCaptureDestinationFolder(
        [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
    )
    {
        return ((delegate* unmanaged<IAppCaptureSettings, IStorageFolder*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_AudioEncodingBitrate([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<IAppCaptureSettings, uint, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_AudioEncodingBitrate([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IAppCaptureSettings, uint*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_IsAudioCaptureEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IAppCaptureSettings, byte, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_IsAudioCaptureEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAppCaptureSettings, byte*, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_CustomVideoEncodingBitrate([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<IAppCaptureSettings, uint, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_CustomVideoEncodingBitrate([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IAppCaptureSettings, uint*, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_CustomVideoEncodingHeight([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<IAppCaptureSettings, uint, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_CustomVideoEncodingHeight([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IAppCaptureSettings, uint*, int>)((*lpVtbl)[15]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_CustomVideoEncodingWidth([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<IAppCaptureSettings, uint, int>)((*lpVtbl)[16]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_CustomVideoEncodingWidth([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IAppCaptureSettings, uint*, int>)((*lpVtbl)[17]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_HistoricalBufferLength([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<IAppCaptureSettings, uint, int>)((*lpVtbl)[18]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_HistoricalBufferLength([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IAppCaptureSettings, uint*, int>)((*lpVtbl)[19]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_HistoricalBufferLengthUnit(
        [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureHistoricalBufferLengthUnit")]
            AppCaptureHistoricalBufferLengthUnit value
    )
    {
        return (
            (delegate* unmanaged<IAppCaptureSettings, AppCaptureHistoricalBufferLengthUnit, int>)(
                (*lpVtbl)[20]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_HistoricalBufferLengthUnit(
        [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureHistoricalBufferLengthUnit *")]
            AppCaptureHistoricalBufferLengthUnit* value
    )
    {
        return (
            (delegate* unmanaged<IAppCaptureSettings, AppCaptureHistoricalBufferLengthUnit*, int>)(
                (*lpVtbl)[21]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_IsHistoricalCaptureEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IAppCaptureSettings, byte, int>)((*lpVtbl)[22]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_IsHistoricalCaptureEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAppCaptureSettings, byte*, int>)((*lpVtbl)[23]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_IsHistoricalCaptureOnBatteryAllowed([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IAppCaptureSettings, byte, int>)((*lpVtbl)[24]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_IsHistoricalCaptureOnBatteryAllowed(
        [NativeTypeName("boolean *")] byte* value
    )
    {
        return ((delegate* unmanaged<IAppCaptureSettings, byte*, int>)((*lpVtbl)[25]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_IsHistoricalCaptureOnWirelessDisplayAllowed(
        [NativeTypeName("boolean")] byte value
    )
    {
        return ((delegate* unmanaged<IAppCaptureSettings, byte, int>)((*lpVtbl)[26]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_IsHistoricalCaptureOnWirelessDisplayAllowed(
        [NativeTypeName("boolean *")] byte* value
    )
    {
        return ((delegate* unmanaged<IAppCaptureSettings, byte*, int>)((*lpVtbl)[27]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_MaximumRecordLength(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value
    )
    {
        return ((delegate* unmanaged<IAppCaptureSettings, TimeSpan, int>)((*lpVtbl)[28]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_MaximumRecordLength(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
    )
    {
        return ((delegate* unmanaged<IAppCaptureSettings, TimeSpan*, int>)((*lpVtbl)[29]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT put_ScreenshotDestinationFolder(
        [NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder value
    )
    {
        return ((delegate* unmanaged<IAppCaptureSettings, IStorageFolder, int>)((*lpVtbl)[30]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_ScreenshotDestinationFolder(
        [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
    )
    {
        return ((delegate* unmanaged<IAppCaptureSettings, IStorageFolder*, int>)((*lpVtbl)[31]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT put_VideoEncodingBitrateMode(
        [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureVideoEncodingBitrateMode")]
            AppCaptureVideoEncodingBitrateMode value
    )
    {
        return (
            (delegate* unmanaged<IAppCaptureSettings, AppCaptureVideoEncodingBitrateMode, int>)(
                (*lpVtbl)[32]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_VideoEncodingBitrateMode(
        [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureVideoEncodingBitrateMode *")]
            AppCaptureVideoEncodingBitrateMode* value
    )
    {
        return (
            (delegate* unmanaged<IAppCaptureSettings, AppCaptureVideoEncodingBitrateMode*, int>)(
                (*lpVtbl)[33]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT put_VideoEncodingResolutionMode(
        [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureVideoEncodingResolutionMode")]
            AppCaptureVideoEncodingResolutionMode value
    )
    {
        return (
            (delegate* unmanaged<IAppCaptureSettings, AppCaptureVideoEncodingResolutionMode, int>)(
                (*lpVtbl)[34]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_VideoEncodingResolutionMode(
        [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureVideoEncodingResolutionMode *")]
            AppCaptureVideoEncodingResolutionMode* value
    )
    {
        return (
            (delegate* unmanaged<IAppCaptureSettings, AppCaptureVideoEncodingResolutionMode*, int>)(
                (*lpVtbl)[35]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT put_IsAppCaptureEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IAppCaptureSettings, byte, int>)((*lpVtbl)[36]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_IsAppCaptureEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAppCaptureSettings, byte*, int>)((*lpVtbl)[37]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_IsCpuConstrained([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAppCaptureSettings, byte*, int>)((*lpVtbl)[38]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_IsDisabledByPolicy([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAppCaptureSettings, byte*, int>)((*lpVtbl)[39]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_IsMemoryConstrained([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAppCaptureSettings, byte*, int>)((*lpVtbl)[40]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_HasHardwareEncoder([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAppCaptureSettings, byte*, int>)((*lpVtbl)[41]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_AppCaptureDestinationFolder(
            [NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder value
        );

        [VtblIndex(7)]
        HRESULT get_AppCaptureDestinationFolder(
            [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
        );

        [VtblIndex(8)]
        HRESULT put_AudioEncodingBitrate([NativeTypeName("UINT32")] uint value);

        [VtblIndex(9)]
        HRESULT get_AudioEncodingBitrate([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(10)]
        HRESULT put_IsAudioCaptureEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(11)]
        HRESULT get_IsAudioCaptureEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(12)]
        HRESULT put_CustomVideoEncodingBitrate([NativeTypeName("UINT32")] uint value);

        [VtblIndex(13)]
        HRESULT get_CustomVideoEncodingBitrate([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(14)]
        HRESULT put_CustomVideoEncodingHeight([NativeTypeName("UINT32")] uint value);

        [VtblIndex(15)]
        HRESULT get_CustomVideoEncodingHeight([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(16)]
        HRESULT put_CustomVideoEncodingWidth([NativeTypeName("UINT32")] uint value);

        [VtblIndex(17)]
        HRESULT get_CustomVideoEncodingWidth([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(18)]
        HRESULT put_HistoricalBufferLength([NativeTypeName("UINT32")] uint value);

        [VtblIndex(19)]
        HRESULT get_HistoricalBufferLength([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(20)]
        HRESULT put_HistoricalBufferLengthUnit(
            [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureHistoricalBufferLengthUnit")]
                AppCaptureHistoricalBufferLengthUnit value
        );

        [VtblIndex(21)]
        HRESULT get_HistoricalBufferLengthUnit(
            [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureHistoricalBufferLengthUnit *")]
                AppCaptureHistoricalBufferLengthUnit* value
        );

        [VtblIndex(22)]
        HRESULT put_IsHistoricalCaptureEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(23)]
        HRESULT get_IsHistoricalCaptureEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(24)]
        HRESULT put_IsHistoricalCaptureOnBatteryAllowed([NativeTypeName("boolean")] byte value);

        [VtblIndex(25)]
        HRESULT get_IsHistoricalCaptureOnBatteryAllowed([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(26)]
        HRESULT put_IsHistoricalCaptureOnWirelessDisplayAllowed(
            [NativeTypeName("boolean")] byte value
        );

        [VtblIndex(27)]
        HRESULT get_IsHistoricalCaptureOnWirelessDisplayAllowed(
            [NativeTypeName("boolean *")] byte* value
        );

        [VtblIndex(28)]
        HRESULT put_MaximumRecordLength(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value
        );

        [VtblIndex(29)]
        HRESULT get_MaximumRecordLength(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
        );

        [VtblIndex(30)]
        HRESULT put_ScreenshotDestinationFolder(
            [NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder value
        );

        [VtblIndex(31)]
        HRESULT get_ScreenshotDestinationFolder(
            [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
        );

        [VtblIndex(32)]
        HRESULT put_VideoEncodingBitrateMode(
            [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureVideoEncodingBitrateMode")]
                AppCaptureVideoEncodingBitrateMode value
        );

        [VtblIndex(33)]
        HRESULT get_VideoEncodingBitrateMode(
            [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureVideoEncodingBitrateMode *")]
                AppCaptureVideoEncodingBitrateMode* value
        );

        [VtblIndex(34)]
        HRESULT put_VideoEncodingResolutionMode(
            [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureVideoEncodingResolutionMode")]
                AppCaptureVideoEncodingResolutionMode value
        );

        [VtblIndex(35)]
        HRESULT get_VideoEncodingResolutionMode(
            [NativeTypeName(
                "ABI::Windows::Media::Capture::AppCaptureVideoEncodingResolutionMode *"
            )]
                AppCaptureVideoEncodingResolutionMode* value
        );

        [VtblIndex(36)]
        HRESULT put_IsAppCaptureEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(37)]
        HRESULT get_IsAppCaptureEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(38)]
        HRESULT get_IsCpuConstrained([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(39)]
        HRESULT get_IsDisabledByPolicy([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(40)]
        HRESULT get_IsMemoryConstrained([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(41)]
        HRESULT get_HasHardwareEncoder([NativeTypeName("boolean *")] byte* value);
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
            "HRESULT (ABI::Windows::Storage::IStorageFolder *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageFolder, int> put_AppCaptureDestinationFolder;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageFolder*, int> get_AppCaptureDestinationFolder;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_AudioEncodingBitrate;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_AudioEncodingBitrate;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsAudioCaptureEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsAudioCaptureEnabled;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_CustomVideoEncodingBitrate;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_CustomVideoEncodingBitrate;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_CustomVideoEncodingHeight;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_CustomVideoEncodingHeight;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_CustomVideoEncodingWidth;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_CustomVideoEncodingWidth;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_HistoricalBufferLength;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_HistoricalBufferLength;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::AppCaptureHistoricalBufferLengthUnit) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AppCaptureHistoricalBufferLengthUnit,
            int> put_HistoricalBufferLengthUnit;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::AppCaptureHistoricalBufferLengthUnit *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AppCaptureHistoricalBufferLengthUnit*,
            int> get_HistoricalBufferLengthUnit;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsHistoricalCaptureEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsHistoricalCaptureEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsHistoricalCaptureOnBatteryAllowed;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsHistoricalCaptureOnBatteryAllowed;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            byte,
            int> put_IsHistoricalCaptureOnWirelessDisplayAllowed;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            byte*,
            int> get_IsHistoricalCaptureOnWirelessDisplayAllowed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan, int> put_MaximumRecordLength;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan*, int> get_MaximumRecordLength;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFolder *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageFolder, int> put_ScreenshotDestinationFolder;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageFolder*, int> get_ScreenshotDestinationFolder;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::AppCaptureVideoEncodingBitrateMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AppCaptureVideoEncodingBitrateMode,
            int> put_VideoEncodingBitrateMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::AppCaptureVideoEncodingBitrateMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AppCaptureVideoEncodingBitrateMode*,
            int> get_VideoEncodingBitrateMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::AppCaptureVideoEncodingResolutionMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AppCaptureVideoEncodingResolutionMode,
            int> put_VideoEncodingResolutionMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::AppCaptureVideoEncodingResolutionMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AppCaptureVideoEncodingResolutionMode*,
            int> get_VideoEncodingResolutionMode;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsAppCaptureEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsAppCaptureEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsCpuConstrained;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsDisabledByPolicy;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsMemoryConstrained;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_HasHardwareEncoder;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppCaptureSettings"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppCaptureSettings(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAppCaptureSettings"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAppCaptureSettings(Silk.NET.WinRT.IInspectable value)
    {
        return new IAppCaptureSettings(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppCaptureSettings"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAppCaptureSettings"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAppCaptureSettings value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppCaptureSettings"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppCaptureSettings(Silk.NET.Windows.IUnknown value)
    {
        return new IAppCaptureSettings(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppCaptureSettings"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppCaptureSettings"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppCaptureSettings value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
