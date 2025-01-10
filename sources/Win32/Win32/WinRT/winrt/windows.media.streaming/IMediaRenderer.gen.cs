// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("2C012EC3-D975-47FB-96AC-A6418B326D2B")]
[NativeTypeName("struct IMediaRenderer : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaRenderer : IMediaRenderer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaRenderer));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaRenderer, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaRenderer, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaRenderer, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaRenderer, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaRenderer, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaRenderer, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsAudioSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IMediaRenderer, byte*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsVideoSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IMediaRenderer, byte*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsImageSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IMediaRenderer, byte*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ActionInformation(
        [NativeTypeName("ABI::Windows::Media::Streaming::IMediaRendererActionInformation **")]
            IMediaRendererActionInformation* value
    )
    {
        return (
            (delegate* unmanaged<IMediaRenderer, IMediaRendererActionInformation*, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetSourceFromUriAsync(
        HSTRING URI,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")]
            IAsyncOperation<uint>** value
    )
    {
        return (
            (delegate* unmanaged<IMediaRenderer, HSTRING, IAsyncOperation<uint>**, int>)(
                (*lpVtbl)[10]
            )
        )(this, URI, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetSourceFromStreamAsync(
        IInspectable stream,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")]
            IAsyncOperation<uint>** value
    )
    {
        return (
            (delegate* unmanaged<IMediaRenderer, IInspectable, IAsyncOperation<uint>**, int>)(
                (*lpVtbl)[11]
            )
        )(this, stream, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetSourceFromMediaSourceAsync(
        IInspectable mediaSource,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")]
            IAsyncOperation<uint>** value
    )
    {
        return (
            (delegate* unmanaged<IMediaRenderer, IInspectable, IAsyncOperation<uint>**, int>)(
                (*lpVtbl)[12]
            )
        )(this, mediaSource, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetNextSourceFromUriAsync(
        HSTRING URI,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")]
            IAsyncOperation<uint>** value
    )
    {
        return (
            (delegate* unmanaged<IMediaRenderer, HSTRING, IAsyncOperation<uint>**, int>)(
                (*lpVtbl)[13]
            )
        )(this, URI, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetNextSourceFromStreamAsync(
        IInspectable stream,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")]
            IAsyncOperation<uint>** value
    )
    {
        return (
            (delegate* unmanaged<IMediaRenderer, IInspectable, IAsyncOperation<uint>**, int>)(
                (*lpVtbl)[14]
            )
        )(this, stream, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetNextSourceFromMediaSourceAsync(
        IInspectable mediaSource,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")]
            IAsyncOperation<uint>** value
    )
    {
        return (
            (delegate* unmanaged<IMediaRenderer, IInspectable, IAsyncOperation<uint>**, int>)(
                (*lpVtbl)[15]
            )
        )(this, mediaSource, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT PlayAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
    )
    {
        return ((delegate* unmanaged<IMediaRenderer, IAsyncAction*, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT PlayAtSpeedAsync(
        [NativeTypeName("ABI::Windows::Media::Streaming::PlaySpeed")] PlaySpeed playSpeed,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
    )
    {
        return (
            (delegate* unmanaged<IMediaRenderer, PlaySpeed, IAsyncAction*, int>)((*lpVtbl)[17])
        )(this, playSpeed, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT StopAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
    )
    {
        return ((delegate* unmanaged<IMediaRenderer, IAsyncAction*, int>)((*lpVtbl)[18]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT PauseAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
    )
    {
        return ((delegate* unmanaged<IMediaRenderer, IAsyncAction*, int>)((*lpVtbl)[19]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetMuteAsync(
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** value
    )
    {
        return ((delegate* unmanaged<IMediaRenderer, IAsyncOperation<byte>**, int>)((*lpVtbl)[20]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT SetMuteAsync(
        [NativeTypeName("boolean")] byte mute,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
    )
    {
        return ((delegate* unmanaged<IMediaRenderer, byte, IAsyncAction*, int>)((*lpVtbl)[21]))(
            this,
            mute,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetVolumeAsync(
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")]
            IAsyncOperation<uint>** value
    )
    {
        return ((delegate* unmanaged<IMediaRenderer, IAsyncOperation<uint>**, int>)((*lpVtbl)[22]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetVolumeAsync(
        [NativeTypeName("UINT32")] uint volume,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
    )
    {
        return ((delegate* unmanaged<IMediaRenderer, uint, IAsyncAction*, int>)((*lpVtbl)[23]))(
            this,
            volume,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SeekAsync(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan target,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
    )
    {
        return ((delegate* unmanaged<IMediaRenderer, TimeSpan, IAsyncAction*, int>)((*lpVtbl)[24]))(
            this,
            target,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetTransportInformationAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CTransportInformation_t **"
        )]
            IAsyncOperation<TransportInformation>** value
    )
    {
        return (
            (delegate* unmanaged<IMediaRenderer, IAsyncOperation<TransportInformation>**, int>)(
                (*lpVtbl)[25]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetPositionInformationAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CPositionInformation_t **"
        )]
            IAsyncOperation<PositionInformation>** value
    )
    {
        return (
            (delegate* unmanaged<IMediaRenderer, IAsyncOperation<PositionInformation>**, int>)(
                (*lpVtbl)[26]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT add_TransportParametersUpdate(
        [NativeTypeName("ABI::Windows::Media::Streaming::ITransportParametersUpdateHandler *")]
            ITransportParametersUpdateHandler handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaRenderer,
                ITransportParametersUpdateHandler,
                EventRegistrationToken*,
                int>)((*lpVtbl)[27])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT remove_TransportParametersUpdate(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IMediaRenderer, EventRegistrationToken, int>)((*lpVtbl)[28]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT add_RenderingParametersUpdate(
        [NativeTypeName("ABI::Windows::Media::Streaming::IRenderingParametersUpdateHandler *")]
            IRenderingParametersUpdateHandler handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaRenderer,
                IRenderingParametersUpdateHandler,
                EventRegistrationToken*,
                int>)((*lpVtbl)[29])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT remove_RenderingParametersUpdate(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IMediaRenderer, EventRegistrationToken, int>)((*lpVtbl)[30]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT NextAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
    )
    {
        return ((delegate* unmanaged<IMediaRenderer, IAsyncAction*, int>)((*lpVtbl)[31]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsAudioSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_IsVideoSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_IsImageSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_ActionInformation(
            [NativeTypeName("ABI::Windows::Media::Streaming::IMediaRendererActionInformation **")]
                IMediaRendererActionInformation* value
        );

        [VtblIndex(10)]
        HRESULT SetSourceFromUriAsync(
            HSTRING URI,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")]
                IAsyncOperation<uint>** value
        );

        [VtblIndex(11)]
        HRESULT SetSourceFromStreamAsync(
            IInspectable stream,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")]
                IAsyncOperation<uint>** value
        );

        [VtblIndex(12)]
        HRESULT SetSourceFromMediaSourceAsync(
            IInspectable mediaSource,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")]
                IAsyncOperation<uint>** value
        );

        [VtblIndex(13)]
        HRESULT SetNextSourceFromUriAsync(
            HSTRING URI,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")]
                IAsyncOperation<uint>** value
        );

        [VtblIndex(14)]
        HRESULT SetNextSourceFromStreamAsync(
            IInspectable stream,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")]
                IAsyncOperation<uint>** value
        );

        [VtblIndex(15)]
        HRESULT SetNextSourceFromMediaSourceAsync(
            IInspectable mediaSource,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")]
                IAsyncOperation<uint>** value
        );

        [VtblIndex(16)]
        HRESULT PlayAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
        );

        [VtblIndex(17)]
        HRESULT PlayAtSpeedAsync(
            [NativeTypeName("ABI::Windows::Media::Streaming::PlaySpeed")] PlaySpeed playSpeed,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
        );

        [VtblIndex(18)]
        HRESULT StopAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
        );

        [VtblIndex(19)]
        HRESULT PauseAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
        );

        [VtblIndex(20)]
        HRESULT GetMuteAsync(
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** value
        );

        [VtblIndex(21)]
        HRESULT SetMuteAsync(
            [NativeTypeName("boolean")] byte mute,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
        );

        [VtblIndex(22)]
        HRESULT GetVolumeAsync(
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")]
                IAsyncOperation<uint>** value
        );

        [VtblIndex(23)]
        HRESULT SetVolumeAsync(
            [NativeTypeName("UINT32")] uint volume,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
        );

        [VtblIndex(24)]
        HRESULT SeekAsync(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan target,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
        );

        [VtblIndex(25)]
        HRESULT GetTransportInformationAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CTransportInformation_t **"
            )]
                IAsyncOperation<TransportInformation>** value
        );

        [VtblIndex(26)]
        HRESULT GetPositionInformationAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CPositionInformation_t **"
            )]
                IAsyncOperation<PositionInformation>** value
        );

        [VtblIndex(27)]
        HRESULT add_TransportParametersUpdate(
            [NativeTypeName("ABI::Windows::Media::Streaming::ITransportParametersUpdateHandler *")]
                ITransportParametersUpdateHandler handler,
            EventRegistrationToken* token
        );

        [VtblIndex(28)]
        HRESULT remove_TransportParametersUpdate(EventRegistrationToken token);

        [VtblIndex(29)]
        HRESULT add_RenderingParametersUpdate(
            [NativeTypeName("ABI::Windows::Media::Streaming::IRenderingParametersUpdateHandler *")]
                IRenderingParametersUpdateHandler handler,
            EventRegistrationToken* token
        );

        [VtblIndex(30)]
        HRESULT remove_RenderingParametersUpdate(EventRegistrationToken token);

        [VtblIndex(31)]
        HRESULT NextAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
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

        [NativeTypeName("HRESULT (::boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsAudioSupported;

        [NativeTypeName("HRESULT (::boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsVideoSupported;

        [NativeTypeName("HRESULT (::boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsImageSupported;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Streaming::IMediaRendererActionInformation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaRendererActionInformation*,
            int> get_ActionInformation;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<uint>**,
            int> SetSourceFromUriAsync;

        [NativeTypeName(
            "HRESULT (IInspectable *, ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IInspectable,
            IAsyncOperation<uint>**,
            int> SetSourceFromStreamAsync;

        [NativeTypeName(
            "HRESULT (IInspectable *, ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IInspectable,
            IAsyncOperation<uint>**,
            int> SetSourceFromMediaSourceAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<uint>**,
            int> SetNextSourceFromUriAsync;

        [NativeTypeName(
            "HRESULT (IInspectable *, ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IInspectable,
            IAsyncOperation<uint>**,
            int> SetNextSourceFromStreamAsync;

        [NativeTypeName(
            "HRESULT (IInspectable *, ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IInspectable,
            IAsyncOperation<uint>**,
            int> SetNextSourceFromMediaSourceAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> PlayAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Streaming::PlaySpeed, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PlaySpeed, IAsyncAction*, int> PlayAtSpeedAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> StopAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> PauseAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<byte>**, int> GetMuteAsync;

        [NativeTypeName(
            "HRESULT (::boolean, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, byte, IAsyncAction*, int> SetMuteAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<uint>**, int> GetVolumeAsync;

        [NativeTypeName(
            "HRESULT (UINT32, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IAsyncAction*, int> SetVolumeAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::TimeSpan, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TimeSpan, IAsyncAction*, int> SeekAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CTransportInformation_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<TransportInformation>**,
            int> GetTransportInformationAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CStreaming__CPositionInformation_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<PositionInformation>**,
            int> GetPositionInformationAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Streaming::ITransportParametersUpdateHandler *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITransportParametersUpdateHandler,
            EventRegistrationToken*,
            int> add_TransportParametersUpdate;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_TransportParametersUpdate;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Streaming::IRenderingParametersUpdateHandler *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IRenderingParametersUpdateHandler,
            EventRegistrationToken*,
            int> add_RenderingParametersUpdate;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_RenderingParametersUpdate;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> NextAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaRenderer"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaRenderer(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaRenderer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaRenderer(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaRenderer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaRenderer"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaRenderer"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaRenderer value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaRenderer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaRenderer(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaRenderer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaRenderer"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaRenderer"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaRenderer value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
