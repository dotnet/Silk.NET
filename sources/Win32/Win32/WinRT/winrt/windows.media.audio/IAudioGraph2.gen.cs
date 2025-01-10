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

[Guid("4E4C3BD5-4FC1-45F6-A947-3CD38F4FD839")]
[NativeTypeName("struct IAudioGraph2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioGraph2 : IAudioGraph2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioGraph2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioGraph2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAudioGraph2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioGraph2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAudioGraph2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAudioGraph2, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAudioGraph2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFrameInputNodeWithFormatAndEmitter(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")]
            IAudioEncodingProperties encodingProperties,
        [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitter *")]
            IAudioNodeEmitter emitter,
        [NativeTypeName("ABI::Windows::Media::Audio::IAudioFrameInputNode **")]
            IAudioFrameInputNode* frameInputNode
    )
    {
        return (
            (delegate* unmanaged<
                IAudioGraph2,
                IAudioEncodingProperties,
                IAudioNodeEmitter,
                IAudioFrameInputNode*,
                int>)((*lpVtbl)[6])
        )(this, encodingProperties, emitter, frameInputNode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateDeviceInputNodeWithFormatAndEmitterOnDeviceAsync(
        [NativeTypeName("ABI::Windows::Media::Capture::MediaCategory")] MediaCategory category,
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")]
            IAudioEncodingProperties encodingProperties,
        [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation *")]
            IDeviceInformation device,
        [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitter *")]
            IAudioNodeEmitter emitter,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioDeviceInputNodeResult_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IAudioGraph2,
                MediaCategory,
                IAudioEncodingProperties,
                IDeviceInformation,
                IAudioNodeEmitter,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, category, encodingProperties, device, emitter, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateFileInputNodeWithEmitterAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitter *")]
            IAudioNodeEmitter emitter,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioFileInputNodeResult_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IAudioGraph2,
                IStorageFile,
                IAudioNodeEmitter,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[8])
        )(this, file, emitter, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateSubmixNodeWithFormatAndEmitter(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")]
            IAudioEncodingProperties encodingProperties,
        [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitter *")]
            IAudioNodeEmitter emitter,
        [NativeTypeName("ABI::Windows::Media::Audio::IAudioInputNode **")]
            IAudioInputNode* submixNode
    )
    {
        return (
            (delegate* unmanaged<
                IAudioGraph2,
                IAudioEncodingProperties,
                IAudioNodeEmitter,
                IAudioInputNode*,
                int>)((*lpVtbl)[9])
        )(this, encodingProperties, emitter, submixNode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateBatchUpdater(
        [NativeTypeName("ABI::Windows::Foundation::IClosable **")] IClosable* updater
    )
    {
        return ((delegate* unmanaged<IAudioGraph2, IClosable*, int>)((*lpVtbl)[10]))(this, updater);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFrameInputNodeWithFormatAndEmitter(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")]
                IAudioEncodingProperties encodingProperties,
            [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitter *")]
                IAudioNodeEmitter emitter,
            [NativeTypeName("ABI::Windows::Media::Audio::IAudioFrameInputNode **")]
                IAudioFrameInputNode* frameInputNode
        );

        [VtblIndex(7)]
        HRESULT CreateDeviceInputNodeWithFormatAndEmitterOnDeviceAsync(
            [NativeTypeName("ABI::Windows::Media::Capture::MediaCategory")] MediaCategory category,
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")]
                IAudioEncodingProperties encodingProperties,
            [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation *")]
                IDeviceInformation device,
            [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitter *")]
                IAudioNodeEmitter emitter,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioDeviceInputNodeResult_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(8)]
        HRESULT CreateFileInputNodeWithEmitterAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitter *")]
                IAudioNodeEmitter emitter,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioFileInputNodeResult_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(9)]
        HRESULT CreateSubmixNodeWithFormatAndEmitter(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")]
                IAudioEncodingProperties encodingProperties,
            [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitter *")]
                IAudioNodeEmitter emitter,
            [NativeTypeName("ABI::Windows::Media::Audio::IAudioInputNode **")]
                IAudioInputNode* submixNode
        );

        [VtblIndex(10)]
        HRESULT CreateBatchUpdater(
            [NativeTypeName("ABI::Windows::Foundation::IClosable **")] IClosable* updater
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
            "HRESULT (ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *, ABI::Windows::Media::Audio::IAudioNodeEmitter *, ABI::Windows::Media::Audio::IAudioFrameInputNode **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAudioEncodingProperties,
            IAudioNodeEmitter,
            IAudioFrameInputNode*,
            int> CreateFrameInputNodeWithFormatAndEmitter;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::MediaCategory, ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *, ABI::Windows::Devices::Enumeration::IDeviceInformation *, ABI::Windows::Media::Audio::IAudioNodeEmitter *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioDeviceInputNodeResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MediaCategory,
            IAudioEncodingProperties,
            IDeviceInformation,
            IAudioNodeEmitter,
            IAsyncOperation<IntPtr>**,
            int> CreateDeviceInputNodeWithFormatAndEmitterOnDeviceAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Media::Audio::IAudioNodeEmitter *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioFileInputNodeResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            IAudioNodeEmitter,
            IAsyncOperation<IntPtr>**,
            int> CreateFileInputNodeWithEmitterAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *, ABI::Windows::Media::Audio::IAudioNodeEmitter *, ABI::Windows::Media::Audio::IAudioInputNode **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAudioEncodingProperties,
            IAudioNodeEmitter,
            IAudioInputNode*,
            int> CreateSubmixNodeWithFormatAndEmitter;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IClosable **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IClosable*, int> CreateBatchUpdater;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioGraph2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioGraph2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAudioGraph2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAudioGraph2(Silk.NET.WinRT.IInspectable value)
    {
        return new IAudioGraph2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioGraph2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioGraph2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAudioGraph2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioGraph2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioGraph2(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioGraph2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioGraph2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioGraph2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioGraph2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
