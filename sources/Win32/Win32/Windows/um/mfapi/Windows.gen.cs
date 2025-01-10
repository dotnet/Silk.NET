// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.DirectX;
using static Silk.NET.Windows.MFWaveFormatExConvertFlags;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFStartup(
        [NativeTypeName("ULONG")] uint Version,
        [NativeTypeName("DWORD")] uint dwFlags = 0
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFShutdown();

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFLockPlatform();

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFUnlockPlatform();

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFPutWorkItem(
        [NativeTypeName("DWORD")] uint dwQueue,
        IMFAsyncCallback pCallback,
        IUnknown pState
    );

    [DllImport("mfplat", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT MFPutWorkItem2(
        [NativeTypeName("DWORD")] uint dwQueue,
        [NativeTypeName("LONG")] int Priority,
        IMFAsyncCallback pCallback,
        IUnknown pState
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFPutWorkItemEx(
        [NativeTypeName("DWORD")] uint dwQueue,
        IMFAsyncResult pResult
    );

    [DllImport("mfplat", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT MFPutWorkItemEx2(
        [NativeTypeName("DWORD")] uint dwQueue,
        [NativeTypeName("LONG")] int Priority,
        IMFAsyncResult pResult
    );

    [DllImport("mfplat", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT MFPutWaitingWorkItem(
        HANDLE hEvent,
        [NativeTypeName("LONG")] int Priority,
        IMFAsyncResult pResult,
        [NativeTypeName("MFWORKITEM_KEY *")] ulong* pKey
    );

    [DllImport("mfplat", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT MFAllocateSerialWorkQueue(
        [NativeTypeName("DWORD")] uint dwWorkQueue,
        [NativeTypeName("DWORD *")] uint* pdwWorkQueue
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFScheduleWorkItemEx(
        IMFAsyncResult pResult,
        [NativeTypeName("INT64")] long Timeout,
        [NativeTypeName("MFWORKITEM_KEY *")] ulong* pKey
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFScheduleWorkItem(
        IMFAsyncCallback pCallback,
        IUnknown pState,
        [NativeTypeName("INT64")] long Timeout,
        [NativeTypeName("MFWORKITEM_KEY *")] ulong* pKey
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFCancelWorkItem([NativeTypeName("MFWORKITEM_KEY")] ulong Key);

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFGetTimerPeriodicity(
        [NativeTypeName("DWORD *")] uint* Periodicity
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFAddPeriodicCallback(
        [NativeTypeName("MFPERIODICCALLBACK")] delegate* unmanaged<IUnknown, void> Callback,
        IUnknown pContext,
        [NativeTypeName("DWORD *")] uint* pdwKey
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFRemovePeriodicCallback([NativeTypeName("DWORD")] uint dwKey);

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFAllocateWorkQueueEx(
        MFASYNC_WORKQUEUE_TYPE WorkQueueType,
        [NativeTypeName("DWORD *")] uint* pdwWorkQueue
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFAllocateWorkQueue(
        [NativeTypeName("DWORD *")] uint* pdwWorkQueue
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFLockWorkQueue([NativeTypeName("DWORD")] uint dwWorkQueue);

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFUnlockWorkQueue([NativeTypeName("DWORD")] uint dwWorkQueue);

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFBeginRegisterWorkQueueWithMMCSS(
        [NativeTypeName("DWORD")] uint dwWorkQueueId,
        [NativeTypeName("LPCWSTR")] ushort* wszClass,
        [NativeTypeName("DWORD")] uint dwTaskId,
        IMFAsyncCallback pDoneCallback,
        IUnknown pDoneState
    );

    [DllImport("mfplat", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT MFBeginRegisterWorkQueueWithMMCSSEx(
        [NativeTypeName("DWORD")] uint dwWorkQueueId,
        [NativeTypeName("LPCWSTR")] ushort* wszClass,
        [NativeTypeName("DWORD")] uint dwTaskId,
        [NativeTypeName("LONG")] int lPriority,
        IMFAsyncCallback pDoneCallback,
        IUnknown pDoneState
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFEndRegisterWorkQueueWithMMCSS(
        IMFAsyncResult pResult,
        [NativeTypeName("DWORD *")] uint* pdwTaskId
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFBeginUnregisterWorkQueueWithMMCSS(
        [NativeTypeName("DWORD")] uint dwWorkQueueId,
        IMFAsyncCallback pDoneCallback,
        IUnknown pDoneState
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFEndUnregisterWorkQueueWithMMCSS(IMFAsyncResult pResult);

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFGetWorkQueueMMCSSClass(
        [NativeTypeName("DWORD")] uint dwWorkQueueId,
        [NativeTypeName("LPWSTR")] ushort* pwszClass,
        [NativeTypeName("DWORD *")] uint* pcchClass
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFGetWorkQueueMMCSSTaskId(
        [NativeTypeName("DWORD")] uint dwWorkQueueId,
        [NativeTypeName("LPDWORD")] uint* pdwTaskId
    );

    [DllImport("mfplat", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT MFRegisterPlatformWithMMCSS(
        [NativeTypeName("PCWSTR")] ushort* wszClass,
        [NativeTypeName("DWORD *")] uint* pdwTaskId,
        [NativeTypeName("LONG")] int lPriority
    );

    [DllImport("mfplat", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT MFUnregisterPlatformFromMMCSS();

    [DllImport("mfplat", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT MFLockSharedWorkQueue(
        [NativeTypeName("PCWSTR")] ushort* wszClass,
        [NativeTypeName("LONG")] int BasePriority,
        [NativeTypeName("DWORD *")] uint* pdwTaskId,
        [NativeTypeName("DWORD *")] uint* pID
    );

    [DllImport("mfplat", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT MFGetWorkQueueMMCSSPriority(
        [NativeTypeName("DWORD")] uint dwWorkQueueId,
        [NativeTypeName("LONG *")] int* lPriority
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFCreateAsyncResult(
        IUnknown punkObject,
        IMFAsyncCallback pCallback,
        IUnknown punkState,
        IMFAsyncResult* ppAsyncResult
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFInvokeCallback(IMFAsyncResult pAsyncResult);

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFCreateFile(
        MF_FILE_ACCESSMODE AccessMode,
        MF_FILE_OPENMODE OpenMode,
        MF_FILE_FLAGS fFlags,
        [NativeTypeName("LPCWSTR")] ushort* pwszFileURL,
        IMFByteStream* ppIByteStream
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFCreateTempFile(
        MF_FILE_ACCESSMODE AccessMode,
        MF_FILE_OPENMODE OpenMode,
        MF_FILE_FLAGS fFlags,
        IMFByteStream* ppIByteStream
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFBeginCreateFile(
        MF_FILE_ACCESSMODE AccessMode,
        MF_FILE_OPENMODE OpenMode,
        MF_FILE_FLAGS fFlags,
        [NativeTypeName("LPCWSTR")] ushort* pwszFilePath,
        IMFAsyncCallback pCallback,
        IUnknown pState,
        IUnknown* ppCancelCookie
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFEndCreateFile(IMFAsyncResult pResult, IMFByteStream* ppFile);

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFCancelCreateFile(IUnknown pCancelCookie);

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFCreateMemoryBuffer(
        [NativeTypeName("DWORD")] uint cbMaxLength,
        IMFMediaBuffer* ppBuffer
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFCreateMediaBufferWrapper(
        IMFMediaBuffer pBuffer,
        [NativeTypeName("DWORD")] uint cbOffset,
        [NativeTypeName("DWORD")] uint dwLength,
        IMFMediaBuffer* ppBuffer
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFCreateLegacyMediaBufferOnMFMediaBuffer(
        IMFSample pSample,
        IMFMediaBuffer pMFMediaBuffer,
        [NativeTypeName("DWORD")] uint cbOffset,
        IMediaBuffer* ppMediaBuffer
    );

    [DllImport("mfplat", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern DXGI_FORMAT MFMapDX9FormatToDXGIFormat([NativeTypeName("DWORD")] uint dx9);

    [DllImport("mfplat", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.2")]
    public static extern uint MFMapDXGIFormatToDX9Format(DXGI_FORMAT dx11);

    [DllImport("mfplat", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT MFLockDXGIDeviceManager(
        uint* pResetToken,
        IMFDXGIDeviceManager* ppManager
    );

    [DllImport("mfplat", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT MFUnlockDXGIDeviceManager();

    [DllImport("evr", ExactSpelling = true)]
    public static extern HRESULT MFCreateDXSurfaceBuffer(
        [NativeTypeName("const IID &")] Guid* riid,
        IUnknown punkSurface,
        BOOL fBottomUpWhenLinear,
        IMFMediaBuffer* ppBuffer
    );

    [DllImport("mfplat", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT MFCreateWICBitmapBuffer(
        [NativeTypeName("const IID &")] Guid* riid,
        IUnknown punkSurface,
        IMFMediaBuffer* ppBuffer
    );

    [DllImport("mfplat", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT MFCreateDXGISurfaceBuffer(
        [NativeTypeName("const IID &")] Guid* riid,
        IUnknown punkSurface,
        uint uSubresourceIndex,
        BOOL fBottomUpWhenLinear,
        IMFMediaBuffer* ppBuffer
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFCreateDXGICrossAdapterBuffer(
        [NativeTypeName("const IID &")] Guid* riid,
        IUnknown punkDevice,
        IMFMediaType pMediaType,
        uint uSubresource,
        IMFMediaBuffer* ppBuffer
    );

    [DllImport("mfplat", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT MFCreateVideoSampleAllocatorEx(
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppSampleAllocator
    );

    [DllImport("mfplat", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT MFCreateDXGIDeviceManager(
        uint* resetToken,
        IMFDXGIDeviceManager* ppDeviceManager
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFGetDXGIDeviceManageMode(
        IUnknown pDeviceManager,
        MF_DXGI_DEVICE_MANAGER_MODE* mode
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFCreateAlignedMemoryBuffer(
        [NativeTypeName("DWORD")] uint cbMaxLength,
        [NativeTypeName("DWORD")] uint cbAligment,
        IMFMediaBuffer* ppBuffer
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFCreateMediaEvent(
        [NativeTypeName("MediaEventType")] uint met,
        [NativeTypeName("const GUID &")] Guid* guidExtendedType,
        HRESULT hrStatus,
        [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvValue,
        IMFMediaEvent* ppEvent
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFCreateEventQueue(IMFMediaEventQueue* ppMediaEventQueue);

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFCreateSample(IMFSample* ppIMFSample);

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_MaxDecodeFrameSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4F,
                0x65,
                0xCC,
                0xD3,
                0xF3,
                0xF9,
                0x13,
                0x4A,
                0x88,
                0x9F,
                0xF0,
                0x4E,
                0xB2,
                0xB5,
                0xB9,
                0x57,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_AccumulatedNonRefPicPercent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xDF,
                0x74,
                0xEA,
                0x79,
                0x40,
                0xA7,
                0x5B,
                0x44,
                0xBC,
                0x98,
                0xC9,
                0xED,
                0x1F,
                0x26,
                0x0E,
                0xEE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_Encryption_ProtectionScheme
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x96,
                0xD0,
                0x54,
                0xD0,
                0xBB,
                0x28,
                0xDA,
                0x45,
                0x87,
                0xEC,
                0x74,
                0xF3,
                0x51,
                0x87,
                0x14,
                0x06,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_Encryption_CryptByteBlock
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9B,
                0x28,
                0x84,
                0x9D,
                0x7F,
                0x0C,
                0x13,
                0x47,
                0xAB,
                0x95,
                0x10,
                0x8A,
                0xB4,
                0x2A,
                0xD8,
                0x01,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_Encryption_SkipByteBlock
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x48,
                0x05,
                0x55,
                0x0D,
                0x17,
                0x83,
                0xB1,
                0x4A,
                0x84,
                0x5F,
                0xD0,
                0x63,
                0x06,
                0xE2,
                0x93,
                0xE3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_Encryption_SubSample_Mapping
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7A,
                0xF2,
                0x44,
                0x84,
                0xA1,
                0x69,
                0xDA,
                0x48,
                0xBD,
                0x08,
                0x11,
                0xCE,
                0xF3,
                0x68,
                0x30,
                0xD2,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_Encryption_ClearSliceHeaderData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF4,
                0xA4,
                0x09,
                0x55,
                0x0D,
                0x32,
                0x6C,
                0x4E,
                0x8D,
                0x1A,
                0x94,
                0xC6,
                0x6D,
                0xD2,
                0x0C,
                0xB0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_Encryption_HardwareProtection_KeyInfoID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEB,
                0xCC,
                0xBF,
                0x8C,
                0xA5,
                0x94,
                0xE1,
                0x4D,
                0x82,
                0x31,
                0xA8,
                0x5E,
                0x47,
                0xCF,
                0x81,
                0xE7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_Encryption_HardwareProtection_KeyInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x80,
                0x20,
                0x37,
                0xB2,
                0x5B,
                0x45,
                0xD7,
                0x4D,
                0x99,
                0x89,
                0x1A,
                0x95,
                0x57,
                0x84,
                0xB7,
                0x54,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_Encryption_HardwareProtection_VideoDecryptorContext
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0x70,
                0x34,
                0x69,
                0x37,
                0xE8,
                0xA0,
                0x47,
                0x88,
                0xCB,
                0x53,
                0x5B,
                0x90,
                0x5E,
                0x35,
                0x82,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_Encryption_Opaque_Data
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE5,
                0x77,
                0x4D,
                0x22,
                0x91,
                0x13,
                0xFB,
                0x4F,
                0x9F,
                0x41,
                0xB4,
                0x32,
                0xF6,
                0x8C,
                0x61,
                0x1D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_NALULengthInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7C,
                0x4E,
                0x12,
                0x19,
                0x4B,
                0xAD,
                0x5F,
                0x46,
                0xBB,
                0x18,
                0x20,
                0x18,
                0x62,
                0x87,
                0xB6,
                0xAF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_Encryption_ResumeVideoOutput
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA5,
                0xAB,
                0x35,
                0xA4,
                0xDE,
                0xAF,
                0xF5,
                0x4C,
                0xBC,
                0x1C,
                0xF6,
                0xAC,
                0xAF,
                0x13,
                0x94,
                0x9D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_Encryption_NALUTypes
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC7,
                0x67,
                0xF0,
                0xB0,
                0x4C,
                0x71,
                0x6C,
                0x41,
                0x8D,
                0x59,
                0x5F,
                0x4D,
                0xDF,
                0x89,
                0x13,
                0xB6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_Encryption_SPSPPSData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA2,
                0x0F,
                0xDE,
                0xAE,
                0x0C,
                0x0E,
                0x3C,
                0x45,
                0xB7,
                0xF3,
                0xDE,
                0x86,
                0x93,
                0x36,
                0x4D,
                0x11,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_Encryption_SEIData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x72,
                0xE9,
                0xF0,
                0x3C,
                0x42,
                0x45,
                0x87,
                0x46,
                0x99,
                0x99,
                0x58,
                0x5F,
                0x56,
                0x5F,
                0xBA,
                0x7D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_Encryption_HardwareProtection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2B,
                0x2D,
                0x2B,
                0x9A,
                0x70,
                0x82,
                0xE3,
                0x43,
                0x84,
                0x48,
                0x99,
                0x4F,
                0x42,
                0x6E,
                0x88,
                0x86,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_CleanPoint
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD8,
                0x01,
                0xDF,
                0x9C,
                0xF0,
                0xA0,
                0xBA,
                0x43,
                0xB0,
                0x77,
                0xEA,
                0xA0,
                0x6C,
                0xBD,
                0x72,
                0x8A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_Discontinuity
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD9,
                0x01,
                0xDF,
                0x9C,
                0xF0,
                0xA0,
                0xBA,
                0x43,
                0xB0,
                0x77,
                0xEA,
                0xA0,
                0x6C,
                0xBD,
                0x72,
                0x8A,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_Token
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x66,
                0xDA,
                0x94,
                0x82,
                0x28,
                0xF3,
                0x05,
                0x48,
                0xB5,
                0x51,
                0x00,
                0xDE,
                0xB4,
                0xC5,
                0x7A,
                0x61,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_ClosedCaption_CEA708
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x68,
                0x90,
                0xF0,
                0x26,
                0x44,
                0xE7,
                0xDC,
                0x47,
                0xAA,
                0x03,
                0xDB,
                0xF2,
                0x04,
                0x03,
                0xBD,
                0xE6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_DecodeTimestamp
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD4,
                0x54,
                0xA9,
                0x73,
                0xE2,
                0x09,
                0x61,
                0x48,
                0xBE,
                0xFC,
                0x94,
                0xBD,
                0x97,
                0xC0,
                0x8E,
                0x6E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_VideoEncodeQP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x78,
                0xE4,
                0xEF,
                0xB2,
                0x79,
                0xF9,
                0x66,
                0x4C,
                0xB9,
                0x5E,
                0xEE,
                0x2B,
                0x82,
                0xC8,
                0x2F,
                0x36,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_VideoEncodePictureType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE6,
                0x04,
                0x37,
                0x97,
                0x14,
                0xCD,
                0x3C,
                0x48,
                0x8F,
                0x20,
                0xC9,
                0xFC,
                0x09,
                0x28,
                0xBA,
                0xD5,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_FrameCorruption
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8C,
                0x4A,
                0xDD,
                0xB4,
                0xEB,
                0x0B,
                0xC4,
                0x44,
                0x8B,
                0x75,
                0xB0,
                0x2B,
                0x91,
                0x3B,
                0x04,
                0xF0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_DirtyRects
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x25,
                0x02,
                0xA7,
                0x9B,
                0x42,
                0xB3,
                0x97,
                0x4E,
                0x91,
                0x26,
                0x0B,
                0x56,
                0x6A,
                0xB7,
                0xEA,
                0x7E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_MoveRegions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x93,
                0xC6,
                0xA6,
                0xE2,
                0x8B,
                0x3A,
                0x8D,
                0x4B,
                0x95,
                0xD0,
                0xF6,
                0x02,
                0x81,
                0xA1,
                0x2F,
                0xB7,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_HDCP_OptionalHeader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x90,
                0x73,
                0x2E,
                0x9A,
                0x1F,
                0x12,
                0x5F,
                0x45,
                0x83,
                0x76,
                0xC9,
                0x74,
                0x28,
                0xE0,
                0xB5,
                0x40,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_HDCP_FrameCounter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x60,
                0x9C,
                0x38,
                0x9D,
                0x07,
                0xF5,
                0xA6,
                0x4A,
                0xA4,
                0x0A,
                0x71,
                0x02,
                0x7A,
                0x02,
                0xF3,
                0xDE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_HDCP_StreamID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x74,
                0x5D,
                0x7E,
                0x17,
                0x70,
                0xC3,
                0x7A,
                0x4A,
                0x95,
                0xA2,
                0x36,
                0x83,
                0x3C,
                0x01,
                0xD0,
                0xAF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_Timestamp
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x99,
                0x69,
                0x43,
                0x1E,
                0xBE,
                0x69,
                0x7A,
                0x4C,
                0x93,
                0x69,
                0x70,
                0x06,
                0x8C,
                0x02,
                0x60,
                0xCB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_RepeatFrame
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x8F,
                0x73,
                0xBE,
                0x88,
                0x11,
                0x07,
                0x42,
                0x4F,
                0xB4,
                0x58,
                0x34,
                0x4A,
                0xED,
                0x42,
                0xEC,
                0x2F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_DescrambleData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE6,
                0x3B,
                0x48,
                0x43,
                0x03,
                0x49,
                0x14,
                0x43,
                0xB0,
                0x32,
                0x29,
                0x51,
                0x36,
                0x59,
                0x36,
                0xFC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_SampleKeyID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC8,
                0x13,
                0xD7,
                0x9E,
                0x87,
                0x9B,
                0x26,
                0x4B,
                0x82,
                0x97,
                0xA9,
                0x3B,
                0x0C,
                0x5A,
                0x8A,
                0xCC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_GenKeyFunc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xEE,
                0xA1,
                0x1C,
                0x44,
                0x1F,
                0x6B,
                0x01,
                0x45,
                0x90,
                0x3A,
                0xDE,
                0x87,
                0xDF,
                0x42,
                0xF6,
                0xED,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_GenKeyCtx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xCB,
                0x20,
                0x81,
                0x18,
                0xDA,
                0xD7,
                0x59,
                0x4B,
                0x9B,
                0x3E,
                0x92,
                0x52,
                0xFD,
                0x37,
                0x30,
                0x1C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_PacketCrossOffsets
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1D,
                0x67,
                0x89,
                0x27,
                0x9F,
                0x38,
                0xBB,
                0x40,
                0x90,
                0xD9,
                0xC2,
                0x82,
                0xF7,
                0x7F,
                0x9A,
                0xBD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_Encryption_SampleID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4E,
                0xB8,
                0x98,
                0x66,
                0xFA,
                0x0A,
                0x30,
                0x43,
                0xAE,
                0xB2,
                0x1C,
                0x0A,
                0x98,
                0xD7,
                0xA4,
                0x4D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_Encryption_KeyID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x91,
                0x65,
                0x37,
                0x76,
                0x5F,
                0x79,
                0xA1,
                0x4D,
                0x86,
                0xED,
                0x9D,
                0x46,
                0xEC,
                0xA1,
                0x09,
                0xA9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_Content_KeyID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB0,
                0xF5,
                0xC7,
                0xC6,
                0xCA,
                0xAC,
                0x5B,
                0x41,
                0x87,
                0xD9,
                0x10,
                0x44,
                0x14,
                0x69,
                0xEF,
                0xC6,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_Encryption_SubSampleMappingSplit
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB9,
                0x54,
                0x02,
                0xFE,
                0xA5,
                0x2A,
                0xDC,
                0x4E,
                0x99,
                0xF7,
                0x17,
                0xE8,
                0x9D,
                0xBF,
                0x91,
                0x74,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_Interlaced
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0A,
                0x83,
                0xD5,
                0xB1,
                0xB8,
                0xDE,
                0xE3,
                0x40,
                0x90,
                0xFA,
                0x38,
                0x99,
                0x43,
                0x71,
                0x64,
                0x61,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_BottomFieldFirst
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA3,
                0xE0,
                0x1C,
                0x94,
                0xE3,
                0x6A,
                0xDA,
                0x4D,
                0x9A,
                0x08,
                0xA6,
                0x42,
                0x98,
                0x34,
                0x06,
                0x17,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_RepeatFirstField
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7C,
                0x25,
                0x4D,
                0x30,
                0x93,
                0x74,
                0xBD,
                0x4F,
                0xB1,
                0x49,
                0x92,
                0x28,
                0xDE,
                0x8D,
                0x9A,
                0x99,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_SingleField
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x16,
                0xF8,
                0x85,
                0x9D,
                0x8B,
                0x65,
                0x5A,
                0x45,
                0xBD,
                0xE0,
                0x9F,
                0xA7,
                0xE1,
                0x5A,
                0xB8,
                0xF9,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_DerivedFromTopField
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5A,
                0x46,
                0x52,
                0x68,
                0x1C,
                0xAE,
                0x53,
                0x45,
                0x8E,
                0x9B,
                0xC3,
                0x42,
                0x0F,
                0xCB,
                0x16,
                0x37,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_MeanAbsoluteDifference
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x11,
                0xDE,
                0xDB,
                0x1C,
                0xB4,
                0x08,
                0x11,
                0x43,
                0xA6,
                0xDD,
                0x0F,
                0x9F,
                0x37,
                0x19,
                0x07,
                0xAA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_LongTermReferenceFrameInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x3F,
                0x73,
                0x54,
                0x91,
                0xBD,
                0xE1,
                0xBF,
                0x41,
                0x81,
                0xD3,
                0xFC,
                0xD9,
                0x18,
                0xF7,
                0x13,
                0x32,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_ROIRectangle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x38,
                0xA4,
                0x14,
                0x34,
                0x98,
                0x49,
                0x2C,
                0x4D,
                0xBE,
                0x82,
                0xBE,
                0x3C,
                0xA0,
                0xB2,
                0x4D,
                0x43,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_LastSlice
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x57,
                0x54,
                0x5D,
                0x2B,
                0x47,
                0x55,
                0x07,
                0x4F,
                0xB8,
                0xC8,
                0xB4,
                0xA3,
                0xA9,
                0xA1,
                0xDA,
                0xAC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_FeatureMap
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x65,
                0xD1,
                0x32,
                0xA0,
                0xFC,
                0x46,
                0x0A,
                0x40,
                0xB4,
                0x49,
                0x49,
                0xDE,
                0x53,
                0xE6,
                0x2A,
                0x6E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_ChromaOnly
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x9C,
                0x17,
                0xB9,
                0x1E,
                0x1F,
                0xA0,
                0x45,
                0x48,
                0x8C,
                0x04,
                0x0E,
                0x65,
                0xA2,
                0x6E,
                0xB0,
                0x4F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_SpatialLayerId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x7B,
                0xBC,
                0xAA,
                0xB7,
                0x96,
                0x23,
                0x7A,
                0x45,
                0x87,
                0x9E,
                0x62,
                0x3B,
                0xFA,
                0xB6,
                0xE0,
                0xAC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_TemporalLayerId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD2,
                0xFC,
                0xC1,
                0xB3,
                0x31,
                0xB3,
                0x76,
                0x43,
                0xB9,
                0x74,
                0xAD,
                0x64,
                0x77,
                0x69,
                0xB2,
                0xB0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_PhotoThumbnail
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x5C,
                0xC8,
                0xBB,
                0x74,
                0xBB,
                0xC8,
                0xDC,
                0x42,
                0xB5,
                0x86,
                0xDA,
                0x17,
                0xFF,
                0xD3,
                0x5D,
                0xCC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_PhotoThumbnailMediaType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x20,
                0x54,
                0xAD,
                0x61,
                0xF8,
                0xEB,
                0x43,
                0x41,
                0x89,
                0xAF,
                0x6B,
                0xF2,
                0x5F,
                0x67,
                0x2D,
                0xEF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_CaptureMetadata
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA8,
                0x23,
                0xBE,
                0x2E,
                0xF5,
                0xFA,
                0x4A,
                0x44,
                0xA6,
                0xA2,
                0xEB,
                0x81,
                0x08,
                0x80,
                0xAB,
                0x5D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_MDLCacheCookie
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF9,
                0x2A,
                0x00,
                0x5F,
                0xF9,
                0xD8,
                0xA3,
                0x41,
                0xB6,
                0xC3,
                0xA2,
                0xAD,
                0x43,
                0xF6,
                0x47,
                0xAD,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_Depth_MinReliableDepth
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB2,
                0x82,
                0x85,
                0x5F,
                0x6B,
                0xE3,
                0xC8,
                0x47,
                0x9B,
                0x87,
                0xFE,
                0xE1,
                0xCA,
                0x72,
                0xC5,
                0xB0,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_Depth_MaxReliableDepth
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0x45,
                0x55,
                0xE4,
                0x0F,
                0x1F,
                0x32,
                0x4A,
                0xA8,
                0xA7,
                0x61,
                0x01,
                0xA2,
                0x4E,
                0xA8,
                0xBE,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFCreateAttributes(
        IMFAttributes* ppMFAttributes,
        [NativeTypeName("UINT32")] uint cInitialSize
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFInitAttributesFromBlob(
        IMFAttributes pAttributes,
        [NativeTypeName("const UINT8 *")] byte* pBuf,
        uint cbBufSize
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFGetAttributesAsBlobSize(
        IMFAttributes pAttributes,
        [NativeTypeName("UINT32 *")] uint* pcbBufSize
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFGetAttributesAsBlob(
        IMFAttributes pAttributes,
        [NativeTypeName("UINT8 *")] byte* pBuf,
        uint cbBufSize
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFTRegister(
        [NativeTypeName("CLSID")] Guid clsidMFT,
        Guid guidCategory,
        [NativeTypeName("LPWSTR")] ushort* pszName,
        [NativeTypeName("UINT32")] uint Flags,
        [NativeTypeName("UINT32")] uint cInputTypes,
        MFT_REGISTER_TYPE_INFO* pInputTypes,
        [NativeTypeName("UINT32")] uint cOutputTypes,
        MFT_REGISTER_TYPE_INFO* pOutputTypes,
        IMFAttributes pAttributes
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFTUnregister([NativeTypeName("CLSID")] Guid clsidMFT);

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFTRegisterLocal(
        IClassFactory pClassFactory,
        [NativeTypeName("const GUID &")] Guid* guidCategory,
        [NativeTypeName("LPCWSTR")] ushort* pszName,
        [NativeTypeName("UINT32")] uint Flags,
        [NativeTypeName("UINT32")] uint cInputTypes,
        [NativeTypeName("const MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pInputTypes,
        [NativeTypeName("UINT32")] uint cOutputTypes,
        [NativeTypeName("const MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pOutputTypes
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFTUnregisterLocal(IClassFactory pClassFactory);

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFTRegisterLocalByCLSID(
        [NativeTypeName("const IID &")] Guid* clisdMFT,
        [NativeTypeName("const GUID &")] Guid* guidCategory,
        [NativeTypeName("LPCWSTR")] ushort* pszName,
        [NativeTypeName("UINT32")] uint Flags,
        [NativeTypeName("UINT32")] uint cInputTypes,
        [NativeTypeName("const MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pInputTypes,
        [NativeTypeName("UINT32")] uint cOutputTypes,
        [NativeTypeName("const MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pOutputTypes
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFTUnregisterLocalByCLSID([NativeTypeName("CLSID")] Guid clsidMFT);

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFTEnum(
        Guid guidCategory,
        [NativeTypeName("UINT32")] uint Flags,
        MFT_REGISTER_TYPE_INFO* pInputType,
        MFT_REGISTER_TYPE_INFO* pOutputType,
        IMFAttributes pAttributes,
        [NativeTypeName("CLSID **")] Guid** ppclsidMFT,
        [NativeTypeName("UINT32 *")] uint* pcMFTs
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFTEnumEx(
        Guid guidCategory,
        [NativeTypeName("UINT32")] uint Flags,
        [NativeTypeName("const MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pInputType,
        [NativeTypeName("const MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pOutputType,
        IMFActivate** pppMFTActivate,
        [NativeTypeName("UINT32 *")] uint* pnumMFTActivate
    );

    [DllImport("mfplat", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0")]
    public static extern HRESULT MFTEnum2(
        Guid guidCategory,
        [NativeTypeName("UINT32")] uint Flags,
        [NativeTypeName("const MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pInputType,
        [NativeTypeName("const MFT_REGISTER_TYPE_INFO *")] MFT_REGISTER_TYPE_INFO* pOutputType,
        IMFAttributes pAttributes,
        IMFActivate** pppMFTActivate,
        [NativeTypeName("UINT32 *")] uint* pnumMFTActivate
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFTGetInfo(
        [NativeTypeName("CLSID")] Guid clsidMFT,
        [NativeTypeName("LPWSTR *")] ushort** pszName,
        MFT_REGISTER_TYPE_INFO** ppInputTypes,
        [NativeTypeName("UINT32 *")] uint* pcInputTypes,
        MFT_REGISTER_TYPE_INFO** ppOutputTypes,
        [NativeTypeName("UINT32 *")] uint* pcOutputTypes,
        IMFAttributes* ppAttributes
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFGetPluginControl(IMFPluginControl* ppPluginControl);

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFGetMFTMerit(
        IUnknown pMFT,
        [NativeTypeName("UINT32")] uint cbVerifier,
        [NativeTypeName("const BYTE *")] byte* verifier,
        [NativeTypeName("DWORD *")] uint* merit
    );

    [DllImport("mfplat", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT MFRegisterLocalSchemeHandler(
        [NativeTypeName("PCWSTR")] ushort* szScheme,
        IMFActivate pActivate
    );

    [DllImport("mfplat", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT MFRegisterLocalByteStreamHandler(
        [NativeTypeName("PCWSTR")] ushort* szFileExtension,
        [NativeTypeName("PCWSTR")] ushort* szMimeType,
        IMFActivate pActivate
    );

    [DllImport("mfplat", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT MFCreateMFByteStreamWrapper(
        IMFByteStream pStream,
        IMFByteStream* ppStreamWrapper
    );

    [DllImport("mfplat", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT MFCreateMediaExtensionActivate(
        [NativeTypeName("PCWSTR")] ushort* szActivatableClassId,
        IUnknown pConfiguration,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPVOID *")] void** ppvObject
    );

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFMPEG4Format_Base
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0x00,
                0x00,
                0x00,
                0x7A,
                0x76,
                0x4D,
                0x49,
                0xB4,
                0x78,
                0xF2,
                0x9D,
                0x25,
                0xDC,
                0x90,
                0x37,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSubtitleFormat_XML
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4F,
                0xF9,
                0x06,
                0x20,
                0xCA,
                0x29,
                0x95,
                0x41,
                0xB8,
                0xDB,
                0x00,
                0xDE,
                0xD8,
                0xFF,
                0x0C,
                0x97,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSubtitleFormat_TTML
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x92,
                0x39,
                0xE7,
                0x73,
                0x10,
                0x9A,
                0x56,
                0x43,
                0x95,
                0x57,
                0x71,
                0x94,
                0xE9,
                0x1E,
                0x3E,
                0x54,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSubtitleFormat_ATSC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA3,
                0xFA,
                0xA7,
                0x7F,
                0xAE,
                0xFE,
                0x16,
                0x4E,
                0xAE,
                0xDF,
                0x36,
                0xB9,
                0xAC,
                0xFB,
                0xB0,
                0x99,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSubtitleFormat_WebVTT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x15,
                0xD2,
                0x86,
                0xC8,
                0x85,
                0xF4,
                0xBB,
                0x40,
                0x8D,
                0xB6,
                0xFA,
                0xDB,
                0xC6,
                0x19,
                0xA4,
                0x5D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSubtitleFormat_SRT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x2E,
                0x7F,
                0x46,
                0x5E,
                0xCA,
                0x77,
                0xA5,
                0x4C,
                0x83,
                0x91,
                0xD1,
                0x42,
                0xED,
                0x4B,
                0x76,
                0xC8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSubtitleFormat_SSA
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x1B,
                0x6A,
                0x17,
                0x57,
                0x9E,
                0x1A,
                0xEA,
                0x4E,
                0xAB,
                0xEF,
                0xC6,
                0x17,
                0x60,
                0x19,
                0x8A,
                0xC4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSubtitleFormat_CustomUserData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x49,
                0xD8,
                0xB3,
                0x1B,
                0x14,
                0x66,
                0x80,
                0x4D,
                0x88,
                0x82,
                0xED,
                0x24,
                0xAA,
                0x82,
                0xDA,
                0x92,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSubtitleFormat_PGS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4A,
                0x0E,
                0xF4,
                0x71,
                0x78,
                0x12,
                0x42,
                0x44,
                0xB3,
                0x0D,
                0x39,
                0xDD,
                0x1D,
                0x77,
                0x22,
                0xBC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSubtitleFormat_VobSub
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF4,
                0x40,
                0x8E,
                0x6B,
                0x2C,
                0x8D,
                0xED,
                0x4C,
                0xAD,
                0x91,
                0x59,
                0x60,
                0xE4,
                0x5B,
                0x44,
                0x33,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFBinaryFormat_Base
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x00,
                0x00,
                0x00,
                0x00,
                0x10,
                0xBF,
                0xB4,
                0x48,
                0xBC,
                0x18,
                0x59,
                0x3D,
                0xC1,
                0xDB,
                0x95,
                0x0F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFBinaryFormat_GPMD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x64,
                0x6D,
                0x70,
                0x67,
                0x10,
                0xBF,
                0xB4,
                0x48,
                0xBC,
                0x18,
                0x59,
                0x3D,
                0xC1,
                0xDB,
                0x95,
                0x0F,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_3DVideo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA4,
                0x97,
                0x6F,
                0xF8,
                0x54,
                0xDD,
                0x2E,
                0x4E,
                0x9A,
                0x5E,
                0x55,
                0xFC,
                0x2D,
                0x74,
                0xA0,
                0x05,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_3DVideo_SampleFormat
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x72,
                0x17,
                0x67,
                0x08,
                0x6F,
                0xE3,
                0xFF,
                0x4C,
                0x97,
                0xB3,
                0xD7,
                0x2E,
                0x20,
                0x98,
                0x7A,
                0x48,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_MULTIPLEXED_MANAGER
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x79,
                0xEE,
                0xCD,
                0x8D,
                0x5A,
                0x6B,
                0x45,
                0x4C,
                0x8D,
                0xB9,
                0x20,
                0xB3,
                0x95,
                0xF0,
                0x2F,
                0xCF,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [DllImport("mfplat", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.15063.0")]
    public static extern HRESULT MFCreateMuxStreamAttributes(
        IMFCollection pAttributesToMux,
        IMFAttributes* ppMuxAttribs
    );

    [DllImport("mfplat", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.15063.0")]
    public static extern HRESULT MFCreateMuxStreamMediaType(
        IMFCollection pMediaTypesToMux,
        IMFMediaType* ppMuxMediaType
    );

    [DllImport("mfplat", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.15063.0")]
    public static extern HRESULT MFCreateMuxStreamSample(
        IMFCollection pSamplesToMux,
        IMFSample* ppMuxSample
    );

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_ForwardedDecodeUnits
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x4C,
                0x75,
                0x4C,
                0x42,
                0xC8,
                0x97,
                0xD6,
                0x48,
                0x87,
                0x77,
                0xFC,
                0x41,
                0xF7,
                0xB6,
                0x08,
                0x79,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_TargetGlobalLuminance
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x36,
                0xEF,
                0x60,
                0x3F,
                0xEF,
                0x31,
                0xAF,
                0x4D,
                0x83,
                0x60,
                0x94,
                0x03,
                0x97,
                0xE4,
                0x1E,
                0xF3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_ForwardedDecodeUnitType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC7,
                0x57,
                0x9E,
                0x08,
                0xD3,
                0x47,
                0x26,
                0x4A,
                0xBF,
                0x9C,
                0x4B,
                0x64,
                0xFA,
                0xFB,
                0x5D,
                0x1E,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFStreamExtension_CameraExtrinsics
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD0,
                0x96,
                0x61,
                0x68,
                0xE2,
                0x13,
                0xD9,
                0x41,
                0x96,
                0x38,
                0xEF,
                0x03,
                0x2C,
                0x27,
                0x2A,
                0x52,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_CameraExtrinsics
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x58,
                0x16,
                0x76,
                0x6B,
                0xEC,
                0xB7,
                0x3B,
                0x4C,
                0x82,
                0x25,
                0x86,
                0x23,
                0xCA,
                0xBE,
                0xC3,
                0x1D,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFStreamExtension_PinholeCameraIntrinsics
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x55,
                0x04,
                0xAC,
                0xDB,
                0xC8,
                0x0E,
                0xEF,
                0x4A,
                0x9C,
                0x32,
                0x7A,
                0x3E,
                0xE3,
                0x45,
                0x6F,
                0x53,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFSampleExtension_PinholeCameraIntrinsics
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xC5,
                0xB6,
                0xE3,
                0x4E,
                0x15,
                0x6A,
                0x72,
                0x4E,
                0x97,
                0x61,
                0x70,
                0xC1,
                0xDB,
                0x8B,
                0x9F,
                0xE3,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFMediaType_Default
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE6,
                0x12,
                0xA4,
                0x81,
                0x03,
                0x81,
                0x06,
                0x4B,
                0x85,
                0x7F,
                0x18,
                0x62,
                0x78,
                0x10,
                0x24,
                0xAC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFMediaType_Audio
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x61,
                0x75,
                0x64,
                0x73,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFMediaType_Video
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x76,
                0x69,
                0x64,
                0x73,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFMediaType_Protected
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xE6,
                0x6F,
                0x4B,
                0x7B,
                0x04,
                0x9D,
                0x94,
                0x44,
                0xBE,
                0x14,
                0x7E,
                0x0B,
                0xD0,
                0x76,
                0xC8,
                0xE4,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFMediaType_SAMI
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xA0,
                0x69,
                0x96,
                0xE6,
                0xCD,
                0x3D,
                0xCB,
                0x40,
                0x9E,
                0x2E,
                0x37,
                0x08,
                0x38,
                0x7C,
                0x06,
                0x16,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFMediaType_Script
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x22,
                0x8C,
                0x17,
                0x72,
                0x5B,
                0xE4,
                0xD5,
                0x11,
                0xBC,
                0x2A,
                0x00,
                0xB0,
                0xD0,
                0xF3,
                0xF4,
                0xAB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFMediaType_Image
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x23,
                0x8C,
                0x17,
                0x72,
                0x5B,
                0xE4,
                0xD5,
                0x11,
                0xBC,
                0x2A,
                0x00,
                0xB0,
                0xD0,
                0xF3,
                0xF4,
                0xAB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFMediaType_HTML
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x24,
                0x8C,
                0x17,
                0x72,
                0x5B,
                0xE4,
                0xD5,
                0x11,
                0xBC,
                0x2A,
                0x00,
                0xB0,
                0xD0,
                0xF3,
                0xF4,
                0xAB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFMediaType_Binary
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x25,
                0x8C,
                0x17,
                0x72,
                0x5B,
                0xE4,
                0xD5,
                0x11,
                0xBC,
                0x2A,
                0x00,
                0xB0,
                0xD0,
                0xF3,
                0xF4,
                0xAB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFMediaType_FileTransfer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x26,
                0x8C,
                0x17,
                0x72,
                0x5B,
                0xE4,
                0xD5,
                0x11,
                0xBC,
                0x2A,
                0x00,
                0xB0,
                0xD0,
                0xF3,
                0xF4,
                0xAB,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFMediaType_Stream
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x83,
                0xEB,
                0x36,
                0xE4,
                0x4F,
                0x52,
                0xCE,
                0x11,
                0x9F,
                0x53,
                0x00,
                0x20,
                0xAF,
                0x0B,
                0xA7,
                0x70,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFMediaType_MultiplexedFrames
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xB0,
                0x42,
                0xA5,
                0x6E,
                0x1F,
                0x28,
                0x31,
                0x42,
                0xA4,
                0x64,
                0xFE,
                0x2F,
                0x50,
                0x22,
                0x50,
                0x1C,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFMediaType_Subtitle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x81,
                0x35,
                0xD1,
                0xA6,
                0x50,
                0xED,
                0x65,
                0x4E,
                0xAE,
                0x08,
                0x26,
                0x06,
                0x55,
                0x76,
                0xAA,
                0xCC,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFMediaType_Perception
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xF9,
                0xF6,
                0x7F,
                0x59,
                0xA2,
                0x6E,
                0x70,
                0x46,
                0x85,
                0xB4,
                0xEA,
                0x84,
                0x07,
                0x3F,
                0xE9,
                0x40,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFImageFormat_JPEG
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xAA,
                0xA5,
                0xE4,
                0x19,
                0x62,
                0x56,
                0xC5,
                0x4F,
                0xA0,
                0xC0,
                0x17,
                0x58,
                0x02,
                0x8E,
                0x10,
                0x57,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFImageFormat_RGB32
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x16,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x10,
                0x00,
                0x80,
                0x00,
                0x00,
                0xAA,
                0x00,
                0x38,
                0x9B,
                0x71,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFStreamFormat_MPEG2Transport
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x23,
                0x80,
                0x6D,
                0xE0,
                0x46,
                0xDB,
                0xCF,
                0x11,
                0xB4,
                0xD1,
                0x00,
                0x80,
                0x5F,
                0x6C,
                0xBB,
                0xEA,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFStreamFormat_MPEG2Program
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0xD1,
                0x67,
                0x30,
                0x26,
                0x30,
                0xD3,
                0xDC,
                0x45,
                0xB6,
                0x69,
                0x34,
                0xD9,
                0x86,
                0xE4,
                0xE3,
                0xE1,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFMediaType_Metadata
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data =
            [
                0x0C,
                0xA2,
                0x8F,
                0x2C,
                0xBB,
                0x82,
                0x82,
                0x47,
                0x90,
                0xA0,
                0x98,
                0xA2,
                0xA5,
                0xBD,
                0x8E,
                0xF8,
            ];
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFValidateMediaTypeSize(
        Guid FormatType,
        [NativeTypeName("UINT8 *")] byte* pBlock,
        [NativeTypeName("UINT32")] uint cbSize
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFCreateMediaType(IMFMediaType* ppMFType);

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFCreateMFVideoFormatFromMFMediaType(
        IMFMediaType pMFType,
        MFVIDEOFORMAT** ppMFVF,
        [NativeTypeName("UINT32 *")] uint* pcbSize
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFCreateWaveFormatExFromMFMediaType(
        IMFMediaType pMFType,
        WAVEFORMATEX** ppWF,
        [NativeTypeName("UINT32 *")] uint* pcbSize,
        [NativeTypeName("UINT32")] uint Flags = (uint)(MFWaveFormatExConvertFlag_Normal)
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFInitMediaTypeFromVideoInfoHeader(
        IMFMediaType pMFType,
        [NativeTypeName("const VIDEOINFOHEADER *")] VIDEOINFOHEADER* pVIH,
        [NativeTypeName("UINT32")] uint cbBufSize,
        [NativeTypeName("const GUID *")] Guid* pSubtype = null
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFInitMediaTypeFromVideoInfoHeader2(
        IMFMediaType pMFType,
        [NativeTypeName("const VIDEOINFOHEADER2 *")] VIDEOINFOHEADER2* pVIH2,
        [NativeTypeName("UINT32")] uint cbBufSize,
        [NativeTypeName("const GUID *")] Guid* pSubtype = null
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFInitMediaTypeFromMPEG1VideoInfo(
        IMFMediaType pMFType,
        [NativeTypeName("const MPEG1VIDEOINFO *")] MPEG1VIDEOINFO* pMP1VI,
        [NativeTypeName("UINT32")] uint cbBufSize,
        [NativeTypeName("const GUID *")] Guid* pSubtype = null
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFInitMediaTypeFromMPEG2VideoInfo(
        IMFMediaType pMFType,
        [NativeTypeName("const MPEG2VIDEOINFO *")] MPEG2VIDEOINFO* pMP2VI,
        [NativeTypeName("UINT32")] uint cbBufSize,
        [NativeTypeName("const GUID *")] Guid* pSubtype = null
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFCalculateBitmapImageSize(
        [NativeTypeName("const BITMAPINFOHEADER *")] BITMAPINFOHEADER* pBMIH,
        [NativeTypeName("UINT32")] uint cbBufSize,
        [NativeTypeName("UINT32 *")] uint* pcbImageSize,
        BOOL* pbKnown = null
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFCalculateImageSize(
        [NativeTypeName("const GUID &")] Guid* guidSubtype,
        [NativeTypeName("UINT32")] uint unWidth,
        [NativeTypeName("UINT32")] uint unHeight,
        [NativeTypeName("UINT32 *")] uint* pcbImageSize
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFFrameRateToAverageTimePerFrame(
        [NativeTypeName("UINT32")] uint unNumerator,
        [NativeTypeName("UINT32")] uint unDenominator,
        [NativeTypeName("UINT64 *")] ulong* punAverageTimePerFrame
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFAverageTimePerFrameToFrameRate(
        [NativeTypeName("UINT64")] ulong unAverageTimePerFrame,
        [NativeTypeName("UINT32 *")] uint* punNumerator,
        [NativeTypeName("UINT32 *")] uint* punDenominator
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFInitMediaTypeFromWaveFormatEx(
        IMFMediaType pMFType,
        [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pWaveFormat,
        [NativeTypeName("UINT32")] uint cbBufSize
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFInitMediaTypeFromMFVideoFormat(
        IMFMediaType pMFType,
        [NativeTypeName("const MFVIDEOFORMAT *")] MFVIDEOFORMAT* pMFVF,
        [NativeTypeName("UINT32")] uint cbBufSize
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFInitMediaTypeFromAMMediaType(
        IMFMediaType pMFType,
        [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pAMType
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFInitAMMediaTypeFromMFMediaType(
        IMFMediaType pMFType,
        Guid guidFormatBlockType,
        AM_MEDIA_TYPE* pAMType
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFCreateAMMediaTypeFromMFMediaType(
        IMFMediaType pMFType,
        Guid guidFormatBlockType,
        AM_MEDIA_TYPE** ppAMType
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern BOOL MFCompareFullToPartialMediaType(
        IMFMediaType pMFTypeFull,
        IMFMediaType pMFTypePartial
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFWrapMediaType(
        IMFMediaType pOrig,
        [NativeTypeName("const GUID &")] Guid* MajorType,
        [NativeTypeName("const GUID &")] Guid* SubType,
        IMFMediaType* ppWrap
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFUnwrapMediaType(IMFMediaType pWrap, IMFMediaType* ppOrig);

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFGetStrideForBitmapInfoHeader(
        [NativeTypeName("DWORD")] uint format,
        [NativeTypeName("DWORD")] uint dwWidth,
        [NativeTypeName("LONG *")] int* pStride
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFCreateVideoMediaType(
        [NativeTypeName("const MFVIDEOFORMAT *")] MFVIDEOFORMAT* pVideoFormat,
        IMFVideoMediaType* ppIVideoMediaType
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFCreateVideoMediaTypeFromSubtype(
        [NativeTypeName("const GUID *")] Guid* pAMSubtype,
        IMFVideoMediaType* ppIVideoMediaType
    );

    [DllImport("evr", ExactSpelling = true)]
    public static extern BOOL MFIsFormatYUV([NativeTypeName("DWORD")] uint Format);

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFCreateVideoMediaTypeFromBitMapInfoHeader(
        [NativeTypeName("const BITMAPINFOHEADER *")] BITMAPINFOHEADER* pbmihBitMapInfoHeader,
        [NativeTypeName("DWORD")] uint dwPixelAspectRatioX,
        [NativeTypeName("DWORD")] uint dwPixelAspectRatioY,
        MFVideoInterlaceMode InterlaceMode,
        [NativeTypeName("QWORD")] ulong VideoFlags,
        [NativeTypeName("QWORD")] ulong qwFramesPerSecondNumerator,
        [NativeTypeName("QWORD")] ulong qwFramesPerSecondDenominator,
        [NativeTypeName("DWORD")] uint dwMaxBitRate,
        IMFVideoMediaType* ppIVideoMediaType
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFGetPlaneSize(
        [NativeTypeName("DWORD")] uint format,
        [NativeTypeName("DWORD")] uint dwWidth,
        [NativeTypeName("DWORD")] uint dwHeight,
        [NativeTypeName("DWORD *")] uint* pdwPlaneSize
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFCreateVideoMediaTypeFromBitMapInfoHeaderEx(
        [NativeTypeName("const BITMAPINFOHEADER *")] BITMAPINFOHEADER* pbmihBitMapInfoHeader,
        [NativeTypeName("UINT32")] uint cbBitMapInfoHeader,
        [NativeTypeName("DWORD")] uint dwPixelAspectRatioX,
        [NativeTypeName("DWORD")] uint dwPixelAspectRatioY,
        MFVideoInterlaceMode InterlaceMode,
        [NativeTypeName("QWORD")] ulong VideoFlags,
        [NativeTypeName("DWORD")] uint dwFramesPerSecondNumerator,
        [NativeTypeName("DWORD")] uint dwFramesPerSecondDenominator,
        [NativeTypeName("DWORD")] uint dwMaxBitRate,
        IMFVideoMediaType* ppIVideoMediaType
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFCreateMediaTypeFromRepresentation(
        Guid guidRepresentation,
        [NativeTypeName("LPVOID")] void* pvRepresentation,
        IMFMediaType* ppIMediaType
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFCreateAudioMediaType(
        [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pAudioFormat,
        IMFAudioMediaType* ppIAudioMediaType
    );

    [DllImport("mfplat", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint MFGetUncompressedVideoFormat(
        [NativeTypeName("const MFVIDEOFORMAT *")] MFVIDEOFORMAT* pVideoFormat
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFInitVideoFormat(
        MFVIDEOFORMAT* pVideoFormat,
        MFStandardVideoFormat type
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFInitVideoFormat_RGB(
        MFVIDEOFORMAT* pVideoFormat,
        [NativeTypeName("DWORD")] uint dwWidth,
        [NativeTypeName("DWORD")] uint dwHeight,
        [NativeTypeName("DWORD")] uint D3Dfmt
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFConvertColorInfoToDXVA(
        [NativeTypeName("DWORD *")] uint* pdwToDXVA,
        [NativeTypeName("const MFVIDEOFORMAT *")] MFVIDEOFORMAT* pFromFormat
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFConvertColorInfoFromDXVA(
        MFVIDEOFORMAT* pToFormat,
        [NativeTypeName("DWORD")] uint dwFromDXVA
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFCopyImage(
        byte* pDest,
        [NativeTypeName("LONG")] int lDestStride,
        [NativeTypeName("const BYTE *")] byte* pSrc,
        [NativeTypeName("LONG")] int lSrcStride,
        [NativeTypeName("DWORD")] uint dwWidthInBytes,
        [NativeTypeName("DWORD")] uint dwLines
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFConvertFromFP16Array(
        float* pDest,
        [NativeTypeName("const WORD *")] ushort* pSrc,
        [NativeTypeName("DWORD")] uint dwCount
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFConvertToFP16Array(
        [NativeTypeName("WORD *")] ushort* pDest,
        [NativeTypeName("const float *")] float* pSrc,
        [NativeTypeName("DWORD")] uint dwCount
    );

    [DllImport("mfplat", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT MFCreate2DMediaBuffer(
        [NativeTypeName("DWORD")] uint dwWidth,
        [NativeTypeName("DWORD")] uint dwHeight,
        [NativeTypeName("DWORD")] uint dwFourCC,
        BOOL fBottomUp,
        IMFMediaBuffer* ppBuffer
    );

    [DllImport("mfplat", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT MFCreateMediaBufferFromMediaType(
        IMFMediaType pMediaType,
        [NativeTypeName("LONGLONG")] long llDuration,
        [NativeTypeName("DWORD")] uint dwMinLength,
        [NativeTypeName("DWORD")] uint dwMinAlignment,
        IMFMediaBuffer* ppBuffer
    );

    [return: NativeTypeName("UINT32")]
    public static uint HI32([NativeTypeName("UINT64")] ulong unPacked)
    {
        return (uint)(unPacked >> 32);
    }

    [return: NativeTypeName("UINT32")]
    public static uint LO32([NativeTypeName("UINT64")] ulong unPacked)
    {
        return (uint)(unPacked);
    }

    [return: NativeTypeName("UINT64")]
    public static ulong Pack2UINT32AsUINT64(
        [NativeTypeName("UINT32")] uint unHigh,
        [NativeTypeName("UINT32")] uint unLow
    )
    {
        return ((ulong)(unHigh) << 32) | unLow;
    }

    public static void Unpack2UINT32AsUINT64(
        [NativeTypeName("UINT64")] ulong unPacked,
        [NativeTypeName("UINT32 *")] uint* punHigh,
        [NativeTypeName("UINT32 *")] uint* punLow
    )
    {
        *punHigh = HI32(unPacked);
        *punLow = LO32(unPacked);
    }

    [return: NativeTypeName("UINT64")]
    [SupportedOSPlatform("windows6.2")]
    public static ulong PackSize(
        [NativeTypeName("UINT32")] uint unWidth,
        [NativeTypeName("UINT32")] uint unHeight
    )
    {
        return Pack2UINT32AsUINT64(unWidth, unHeight);
    }

    [SupportedOSPlatform("windows6.2")]
    public static void UnpackSize(
        [NativeTypeName("UINT64")] ulong unPacked,
        [NativeTypeName("UINT32 *")] uint* punWidth,
        [NativeTypeName("UINT32 *")] uint* punHeight
    )
    {
        Unpack2UINT32AsUINT64(unPacked, punWidth, punHeight);
    }

    [return: NativeTypeName("UINT64")]
    [SupportedOSPlatform("windows6.2")]
    public static ulong PackRatio(
        [NativeTypeName("INT32")] int nNumerator,
        [NativeTypeName("UINT32")] uint unDenominator
    )
    {
        return Pack2UINT32AsUINT64((uint)(nNumerator), unDenominator);
    }

    public static void UnpackRatio(
        [NativeTypeName("UINT64")] ulong unPacked,
        [NativeTypeName("INT32 *")] int* pnNumerator,
        [NativeTypeName("UINT32 *")] uint* punDenominator
    )
    {
        Unpack2UINT32AsUINT64(unPacked, unchecked((uint*)(pnNumerator)), punDenominator);
    }

    [return: NativeTypeName("UINT32")]
    public static uint MFGetAttributeUINT32(
        IMFAttributes pAttributes,
        [NativeTypeName("const GUID &")] Guid* guidKey,
        [NativeTypeName("UINT32")] uint unDefault
    )
    {
        uint unRet;
        if ((((HRESULT)(pAttributes.GetUINT32(guidKey, &unRet))) < 0))
        {
            unRet = unDefault;
        }
        return unRet;
    }

    [return: NativeTypeName("UINT64")]
    public static ulong MFGetAttributeUINT64(
        IMFAttributes pAttributes,
        [NativeTypeName("const GUID &")] Guid* guidKey,
        [NativeTypeName("UINT64")] ulong unDefault
    )
    {
        ulong unRet;
        if ((((HRESULT)(pAttributes.GetUINT64(guidKey, &unRet))) < 0))
        {
            unRet = unDefault;
        }
        return unRet;
    }

    public static double MFGetAttributeDouble(
        IMFAttributes pAttributes,
        [NativeTypeName("const GUID &")] Guid* guidKey,
        double fDefault
    )
    {
        double fRet;
        if ((((HRESULT)(pAttributes.GetDouble(guidKey, &fRet))) < 0))
        {
            fRet = fDefault;
        }
        return fRet;
    }

    public static HRESULT MFGetAttribute2UINT32asUINT64(
        IMFAttributes pAttributes,
        [NativeTypeName("const GUID &")] Guid* guidKey,
        [NativeTypeName("UINT32 *")] uint* punHigh32,
        [NativeTypeName("UINT32 *")] uint* punLow32
    )
    {
        ulong unPacked;
        HRESULT hr = ((HRESULT)(0));
        hr = pAttributes.GetUINT64(guidKey, &unPacked);
        if ((((HRESULT)(hr)) < 0))
        {
            return hr;
        }
        Unpack2UINT32AsUINT64(unPacked, punHigh32, punLow32);
        return hr;
    }

    public static HRESULT MFSetAttribute2UINT32asUINT64(
        IMFAttributes pAttributes,
        [NativeTypeName("const GUID &")] Guid* guidKey,
        [NativeTypeName("UINT32")] uint unHigh32,
        [NativeTypeName("UINT32")] uint unLow32
    )
    {
        return pAttributes.SetUINT64(guidKey, Pack2UINT32AsUINT64(unHigh32, unLow32));
    }

    public static HRESULT MFGetAttributeRatio(
        IMFAttributes pAttributes,
        [NativeTypeName("const GUID &")] Guid* guidKey,
        [NativeTypeName("UINT32 *")] uint* punNumerator,
        [NativeTypeName("UINT32 *")] uint* punDenominator
    )
    {
        return MFGetAttribute2UINT32asUINT64(pAttributes, guidKey, punNumerator, punDenominator);
    }

    public static HRESULT MFGetAttributeSize(
        IMFAttributes pAttributes,
        [NativeTypeName("const GUID &")] Guid* guidKey,
        [NativeTypeName("UINT32 *")] uint* punWidth,
        [NativeTypeName("UINT32 *")] uint* punHeight
    )
    {
        return MFGetAttribute2UINT32asUINT64(pAttributes, guidKey, punWidth, punHeight);
    }

    public static HRESULT MFSetAttributeRatio(
        IMFAttributes pAttributes,
        [NativeTypeName("const GUID &")] Guid* guidKey,
        [NativeTypeName("UINT32")] uint unNumerator,
        [NativeTypeName("UINT32")] uint unDenominator
    )
    {
        return MFSetAttribute2UINT32asUINT64(pAttributes, guidKey, unNumerator, unDenominator);
    }

    public static HRESULT MFSetAttributeSize(
        IMFAttributes pAttributes,
        [NativeTypeName("const GUID &")] Guid* guidKey,
        [NativeTypeName("UINT32")] uint unWidth,
        [NativeTypeName("UINT32")] uint unHeight
    )
    {
        return MFSetAttribute2UINT32asUINT64(pAttributes, guidKey, unWidth, unHeight);
    }

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFCreateCollection(IMFCollection* ppIMFCollection);

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern void* MFHeapAlloc(
        [NativeTypeName("size_t")] nuint nSize,
        [NativeTypeName("ULONG")] uint dwFlags,
        [NativeTypeName("char *")] sbyte* pszFile,
        int line,
        EAllocationType eat
    );

    [DllImport("mfplat", ExactSpelling = true)]
    public static extern void MFHeapFree(void* pv);

    [DllImport("mfplat", ExactSpelling = true)]
    [return: NativeTypeName("LONGLONG")]
    public static extern long MFllMulDiv(
        [NativeTypeName("LONGLONG")] long a,
        [NativeTypeName("LONGLONG")] long b,
        [NativeTypeName("LONGLONG")] long c,
        [NativeTypeName("LONGLONG")] long d
    );

    [DllImport("mfplat", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT MFGetContentProtectionSystemCLSID(
        [NativeTypeName("const GUID &")] Guid* guidProtectionSystemID,
        [NativeTypeName("CLSID *")] Guid* pclsid
    );

    [DllImport("mfplat", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19041.0")]
    public static extern HRESULT MFCombineSamples(
        IMFSample pSample,
        IMFSample pSampleToAdd,
        [NativeTypeName("DWORD")] uint dwMaxMergedDurationInMS,
        BOOL* pMerged
    );

    [DllImport("mfplat", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19041.0")]
    public static extern HRESULT MFSplitSample(
        IMFSample pSample,
        IMFSample* pOutputSamples,
        [NativeTypeName("DWORD")] uint dwOutputSampleMaxCount,
        [NativeTypeName("DWORD *")] uint* pdwOutputSampleCount
    );

    [NativeTypeName("#define MFSTARTUP_NOSOCKET 0x1")]
    public const int MFSTARTUP_NOSOCKET = 0x1;

    [NativeTypeName("#define MFSTARTUP_LITE (MFSTARTUP_NOSOCKET)")]
    public const int MFSTARTUP_LITE = (0x1);

    [NativeTypeName("#define MFSTARTUP_FULL 0")]
    public const int MFSTARTUP_FULL = 0;

    [NativeTypeName("#define MFSESSIONCAP_START 0x00000001")]
    public const int MFSESSIONCAP_START = 0x00000001;

    [NativeTypeName("#define MFSESSIONCAP_SEEK 0x00000002")]
    public const int MFSESSIONCAP_SEEK = 0x00000002;

    [NativeTypeName("#define MFSESSIONCAP_PAUSE 0x00000004")]
    public const int MFSESSIONCAP_PAUSE = 0x00000004;

    [NativeTypeName("#define MFSESSIONCAP_RATE_FORWARD 0x00000010")]
    public const int MFSESSIONCAP_RATE_FORWARD = 0x00000010;

    [NativeTypeName("#define MFSESSIONCAP_RATE_REVERSE 0x00000020")]
    public const int MFSESSIONCAP_RATE_REVERSE = 0x00000020;

    [NativeTypeName("#define MFSESSIONCAP_DOES_NOT_USE_NETWORK 0x00000040")]
    public const int MFSESSIONCAP_DOES_NOT_USE_NETWORK = 0x00000040;

    [NativeTypeName("#define MFSampleExtension_ClosedCaption_CEA708_MAX_SIZE 256")]
    public const int MFSampleExtension_ClosedCaption_CEA708_MAX_SIZE = 256;

    [NativeTypeName("#define MACROBLOCK_FLAG_SKIP 0x00000001")]
    public const int MACROBLOCK_FLAG_SKIP = 0x00000001;

    [NativeTypeName("#define MACROBLOCK_FLAG_DIRTY 0x00000002")]
    public const int MACROBLOCK_FLAG_DIRTY = 0x00000002;

    [NativeTypeName("#define MACROBLOCK_FLAG_MOTION 0x00000004")]
    public const int MACROBLOCK_FLAG_MOTION = 0x00000004;

    [NativeTypeName("#define MACROBLOCK_FLAG_VIDEO 0x00000008")]
    public const int MACROBLOCK_FLAG_VIDEO = 0x00000008;

    [NativeTypeName("#define MACROBLOCK_FLAG_HAS_MOTION_VECTOR 0x00000010")]
    public const int MACROBLOCK_FLAG_HAS_MOTION_VECTOR = 0x00000010;

    [NativeTypeName("#define MACROBLOCK_FLAG_HAS_QP 0x00000020")]
    public const int MACROBLOCK_FLAG_HAS_QP = 0x00000020;

    [NativeTypeName("#define MFCAPTURE_METADATA_SCAN_RIGHT_LEFT 0x00000001")]
    public const int MFCAPTURE_METADATA_SCAN_RIGHT_LEFT = 0x00000001;

    [NativeTypeName("#define MFCAPTURE_METADATA_SCAN_BOTTOM_TOP 0x00000002")]
    public const int MFCAPTURE_METADATA_SCAN_BOTTOM_TOP = 0x00000002;

    [NativeTypeName("#define MFCAPTURE_METADATA_SCANLINE_VERTICAL 0x00000004")]
    public const int MFCAPTURE_METADATA_SCANLINE_VERTICAL = 0x00000004;

    [NativeTypeName("#define LOCAL_D3DFMT_DEFINES 1")]
    public const int LOCAL_D3DFMT_DEFINES = 1;
}
