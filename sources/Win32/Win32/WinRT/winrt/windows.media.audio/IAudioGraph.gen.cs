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

[Guid("1AD46EED-E48C-4E14-9660-2C4F83E9CDD8")]
[NativeTypeName("struct IAudioGraph : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioGraph : IAudioGraph.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioGraph));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioGraph, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAudioGraph, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioGraph, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAudioGraph, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAudioGraph, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAudioGraph, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFrameInputNode(
        [NativeTypeName("ABI::Windows::Media::Audio::IAudioFrameInputNode **")]
            IAudioFrameInputNode* frameInputNode
    )
    {
        return ((delegate* unmanaged<IAudioGraph, IAudioFrameInputNode*, int>)((*lpVtbl)[6]))(
            this,
            frameInputNode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFrameInputNodeWithFormat(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")]
            IAudioEncodingProperties encodingProperties,
        [NativeTypeName("ABI::Windows::Media::Audio::IAudioFrameInputNode **")]
            IAudioFrameInputNode* frameInputNode
    )
    {
        return (
            (delegate* unmanaged<
                IAudioGraph,
                IAudioEncodingProperties,
                IAudioFrameInputNode*,
                int>)((*lpVtbl)[7])
        )(this, encodingProperties, frameInputNode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateDeviceInputNodeAsync(
        [NativeTypeName("ABI::Windows::Media::Capture::MediaCategory")] MediaCategory category,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioDeviceInputNodeResult_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IAudioGraph, MediaCategory, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[8]
            )
        )(this, category, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateDeviceInputNodeWithFormatAsync(
        [NativeTypeName("ABI::Windows::Media::Capture::MediaCategory")] MediaCategory category,
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")]
            IAudioEncodingProperties encodingProperties,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioDeviceInputNodeResult_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IAudioGraph,
                MediaCategory,
                IAudioEncodingProperties,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[9])
        )(this, category, encodingProperties, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateDeviceInputNodeWithFormatOnDeviceAsync(
        [NativeTypeName("ABI::Windows::Media::Capture::MediaCategory")] MediaCategory category,
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")]
            IAudioEncodingProperties encodingProperties,
        [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation *")]
            IDeviceInformation device,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioDeviceInputNodeResult_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IAudioGraph,
                MediaCategory,
                IAudioEncodingProperties,
                IDeviceInformation,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[10])
        )(this, category, encodingProperties, device, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateFrameOutputNode(
        [NativeTypeName("ABI::Windows::Media::Audio::IAudioFrameOutputNode **")]
            IAudioFrameOutputNode* frameOutputNode
    )
    {
        return ((delegate* unmanaged<IAudioGraph, IAudioFrameOutputNode*, int>)((*lpVtbl)[11]))(
            this,
            frameOutputNode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateFrameOutputNodeWithFormat(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")]
            IAudioEncodingProperties encodingProperties,
        [NativeTypeName("ABI::Windows::Media::Audio::IAudioFrameOutputNode **")]
            IAudioFrameOutputNode* frameOutputNode
    )
    {
        return (
            (delegate* unmanaged<
                IAudioGraph,
                IAudioEncodingProperties,
                IAudioFrameOutputNode*,
                int>)((*lpVtbl)[12])
        )(this, encodingProperties, frameOutputNode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateDeviceOutputNodeAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioDeviceOutputNodeResult_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return ((delegate* unmanaged<IAudioGraph, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[13]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateFileInputNodeAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioFileInputNodeResult_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IAudioGraph, IStorageFile, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[14]
            )
        )(this, file, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateFileOutputNodeAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioFileOutputNodeResult_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IAudioGraph, IStorageFile, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[15]
            )
        )(this, file, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateFileOutputNodeWithFileProfileAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")]
            IMediaEncodingProfile fileEncodingProfile,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioFileOutputNodeResult_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IAudioGraph,
                IStorageFile,
                IMediaEncodingProfile,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[16])
        )(this, file, fileEncodingProfile, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CreateSubmixNode(
        [NativeTypeName("ABI::Windows::Media::Audio::IAudioInputNode **")]
            IAudioInputNode* submixNode
    )
    {
        return ((delegate* unmanaged<IAudioGraph, IAudioInputNode*, int>)((*lpVtbl)[17]))(
            this,
            submixNode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CreateSubmixNodeWithFormat(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")]
            IAudioEncodingProperties encodingProperties,
        [NativeTypeName("ABI::Windows::Media::Audio::IAudioInputNode **")]
            IAudioInputNode* submixNode
    )
    {
        return (
            (delegate* unmanaged<IAudioGraph, IAudioEncodingProperties, IAudioInputNode*, int>)(
                (*lpVtbl)[18]
            )
        )(this, encodingProperties, submixNode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged<IAudioGraph, int>)((*lpVtbl)[19]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<IAudioGraph, int>)((*lpVtbl)[20]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT ResetAllNodes()
    {
        return ((delegate* unmanaged<IAudioGraph, int>)((*lpVtbl)[21]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT add_QuantumStarted(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioGraph_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IAudioGraph,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[22])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT remove_QuantumStarted(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IAudioGraph, EventRegistrationToken, int>)((*lpVtbl)[23]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT add_QuantumProcessed(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioGraph_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IAudioGraph,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[24])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT remove_QuantumProcessed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IAudioGraph, EventRegistrationToken, int>)((*lpVtbl)[25]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT add_UnrecoverableErrorOccurred(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioGraph_Windows__CMedia__CAudio__CAudioGraphUnrecoverableErrorOccurredEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IAudioGraph,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[26])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT remove_UnrecoverableErrorOccurred(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IAudioGraph, EventRegistrationToken, int>)((*lpVtbl)[27]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_CompletedQuantumCount([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged<IAudioGraph, ulong*, int>)((*lpVtbl)[28]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_EncodingProperties(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")]
            IAudioEncodingProperties* value
    )
    {
        return ((delegate* unmanaged<IAudioGraph, IAudioEncodingProperties*, int>)((*lpVtbl)[29]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_LatencyInSamples([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IAudioGraph, int*, int>)((*lpVtbl)[30]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_PrimaryRenderDevice(
        [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation **")]
            IDeviceInformation* value
    )
    {
        return ((delegate* unmanaged<IAudioGraph, IDeviceInformation*, int>)((*lpVtbl)[31]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_RenderDeviceAudioProcessing(
        [NativeTypeName("ABI::Windows::Media::AudioProcessing *")] AudioProcessing* value
    )
    {
        return ((delegate* unmanaged<IAudioGraph, AudioProcessing*, int>)((*lpVtbl)[32]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_SamplesPerQuantum([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IAudioGraph, int*, int>)((*lpVtbl)[33]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFrameInputNode(
            [NativeTypeName("ABI::Windows::Media::Audio::IAudioFrameInputNode **")]
                IAudioFrameInputNode* frameInputNode
        );

        [VtblIndex(7)]
        HRESULT CreateFrameInputNodeWithFormat(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")]
                IAudioEncodingProperties encodingProperties,
            [NativeTypeName("ABI::Windows::Media::Audio::IAudioFrameInputNode **")]
                IAudioFrameInputNode* frameInputNode
        );

        [VtblIndex(8)]
        HRESULT CreateDeviceInputNodeAsync(
            [NativeTypeName("ABI::Windows::Media::Capture::MediaCategory")] MediaCategory category,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioDeviceInputNodeResult_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(9)]
        HRESULT CreateDeviceInputNodeWithFormatAsync(
            [NativeTypeName("ABI::Windows::Media::Capture::MediaCategory")] MediaCategory category,
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")]
                IAudioEncodingProperties encodingProperties,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioDeviceInputNodeResult_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(10)]
        HRESULT CreateDeviceInputNodeWithFormatOnDeviceAsync(
            [NativeTypeName("ABI::Windows::Media::Capture::MediaCategory")] MediaCategory category,
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")]
                IAudioEncodingProperties encodingProperties,
            [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation *")]
                IDeviceInformation device,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioDeviceInputNodeResult_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(11)]
        HRESULT CreateFrameOutputNode(
            [NativeTypeName("ABI::Windows::Media::Audio::IAudioFrameOutputNode **")]
                IAudioFrameOutputNode* frameOutputNode
        );

        [VtblIndex(12)]
        HRESULT CreateFrameOutputNodeWithFormat(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")]
                IAudioEncodingProperties encodingProperties,
            [NativeTypeName("ABI::Windows::Media::Audio::IAudioFrameOutputNode **")]
                IAudioFrameOutputNode* frameOutputNode
        );

        [VtblIndex(13)]
        HRESULT CreateDeviceOutputNodeAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioDeviceOutputNodeResult_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(14)]
        HRESULT CreateFileInputNodeAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioFileInputNodeResult_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(15)]
        HRESULT CreateFileOutputNodeAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioFileOutputNodeResult_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(16)]
        HRESULT CreateFileOutputNodeWithFileProfileAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *")]
                IMediaEncodingProfile fileEncodingProfile,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioFileOutputNodeResult_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(17)]
        HRESULT CreateSubmixNode(
            [NativeTypeName("ABI::Windows::Media::Audio::IAudioInputNode **")]
                IAudioInputNode* submixNode
        );

        [VtblIndex(18)]
        HRESULT CreateSubmixNodeWithFormat(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *")]
                IAudioEncodingProperties encodingProperties,
            [NativeTypeName("ABI::Windows::Media::Audio::IAudioInputNode **")]
                IAudioInputNode* submixNode
        );

        [VtblIndex(19)]
        HRESULT Start();

        [VtblIndex(20)]
        HRESULT Stop();

        [VtblIndex(21)]
        HRESULT ResetAllNodes();

        [VtblIndex(22)]
        HRESULT add_QuantumStarted(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioGraph_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(23)]
        HRESULT remove_QuantumStarted(EventRegistrationToken token);

        [VtblIndex(24)]
        HRESULT add_QuantumProcessed(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioGraph_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(25)]
        HRESULT remove_QuantumProcessed(EventRegistrationToken token);

        [VtblIndex(26)]
        HRESULT add_UnrecoverableErrorOccurred(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioGraph_Windows__CMedia__CAudio__CAudioGraphUnrecoverableErrorOccurredEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(27)]
        HRESULT remove_UnrecoverableErrorOccurred(EventRegistrationToken token);

        [VtblIndex(28)]
        HRESULT get_CompletedQuantumCount([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(29)]
        HRESULT get_EncodingProperties(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **")]
                IAudioEncodingProperties* value
        );

        [VtblIndex(30)]
        HRESULT get_LatencyInSamples([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(31)]
        HRESULT get_PrimaryRenderDevice(
            [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceInformation **")]
                IDeviceInformation* value
        );

        [VtblIndex(32)]
        HRESULT get_RenderDeviceAudioProcessing(
            [NativeTypeName("ABI::Windows::Media::AudioProcessing *")] AudioProcessing* value
        );

        [VtblIndex(33)]
        HRESULT get_SamplesPerQuantum([NativeTypeName("INT32 *")] int* value);
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
            "HRESULT (ABI::Windows::Media::Audio::IAudioFrameInputNode **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAudioFrameInputNode*, int> CreateFrameInputNode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *, ABI::Windows::Media::Audio::IAudioFrameInputNode **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAudioEncodingProperties,
            IAudioFrameInputNode*,
            int> CreateFrameInputNodeWithFormat;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::MediaCategory, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioDeviceInputNodeResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MediaCategory,
            IAsyncOperation<IntPtr>**,
            int> CreateDeviceInputNodeAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::MediaCategory, ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioDeviceInputNodeResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MediaCategory,
            IAudioEncodingProperties,
            IAsyncOperation<IntPtr>**,
            int> CreateDeviceInputNodeWithFormatAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::MediaCategory, ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *, ABI::Windows::Devices::Enumeration::IDeviceInformation *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioDeviceInputNodeResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MediaCategory,
            IAudioEncodingProperties,
            IDeviceInformation,
            IAsyncOperation<IntPtr>**,
            int> CreateDeviceInputNodeWithFormatOnDeviceAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Audio::IAudioFrameOutputNode **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAudioFrameOutputNode*, int> CreateFrameOutputNode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *, ABI::Windows::Media::Audio::IAudioFrameOutputNode **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAudioEncodingProperties,
            IAudioFrameOutputNode*,
            int> CreateFrameOutputNodeWithFormat;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioDeviceOutputNodeResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<IntPtr>**,
            int> CreateDeviceOutputNodeAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioFileInputNodeResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            IAsyncOperation<IntPtr>**,
            int> CreateFileInputNodeAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioFileOutputNodeResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            IAsyncOperation<IntPtr>**,
            int> CreateFileOutputNodeAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Media::MediaProperties::IMediaEncodingProfile *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateAudioFileOutputNodeResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            IMediaEncodingProfile,
            IAsyncOperation<IntPtr>**,
            int> CreateFileOutputNodeWithFileProfileAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Audio::IAudioInputNode **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAudioInputNode*, int> CreateSubmixNode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IAudioEncodingProperties *, ABI::Windows::Media::Audio::IAudioInputNode **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAudioEncodingProperties,
            IAudioInputNode*,
            int> CreateSubmixNodeWithFormat;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Start;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Stop;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ResetAllNodes;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioGraph_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_QuantumStarted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_QuantumStarted;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioGraph_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_QuantumProcessed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_QuantumProcessed;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioGraph_Windows__CMedia__CAudio__CAudioGraphUnrecoverableErrorOccurredEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_UnrecoverableErrorOccurred;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_UnrecoverableErrorOccurred;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_CompletedQuantumCount;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IAudioEncodingProperties **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAudioEncodingProperties*, int> get_EncodingProperties;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_LatencyInSamples;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Enumeration::IDeviceInformation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDeviceInformation*, int> get_PrimaryRenderDevice;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::AudioProcessing *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AudioProcessing*, int> get_RenderDeviceAudioProcessing;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_SamplesPerQuantum;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioGraph"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioGraph(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAudioGraph"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAudioGraph(Silk.NET.WinRT.IInspectable value)
    {
        return new IAudioGraph(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioGraph"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioGraph"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAudioGraph value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioGraph"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioGraph(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioGraph(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioGraph"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioGraph"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioGraph value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
