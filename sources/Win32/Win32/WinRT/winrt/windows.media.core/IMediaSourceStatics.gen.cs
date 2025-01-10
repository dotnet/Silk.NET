// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("F77D6FA4-4652-410E-B1D8-E9A5E245A45C")]
[NativeTypeName("struct IMediaSourceStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaSourceStatics : IMediaSourceStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaSourceStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaSourceStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaSourceStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaSourceStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaSourceStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaSourceStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaSourceStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromAdaptiveMediaSource(
        [NativeTypeName("ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSource *")]
            IAdaptiveMediaSource mediaSource,
        [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2* result
    )
    {
        return (
            (delegate* unmanaged<IMediaSourceStatics, IAdaptiveMediaSource, IMediaSource2*, int>)(
                (*lpVtbl)[6]
            )
        )(this, mediaSource, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromMediaStreamSource(
        [NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSource *")]
            IMediaStreamSource mediaSource,
        [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2* result
    )
    {
        return (
            (delegate* unmanaged<IMediaSourceStatics, IMediaStreamSource, IMediaSource2*, int>)(
                (*lpVtbl)[7]
            )
        )(this, mediaSource, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateFromMseStreamSource(
        [NativeTypeName("ABI::Windows::Media::Core::IMseStreamSource *")]
            IMseStreamSource mediaSource,
        [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2* result
    )
    {
        return (
            (delegate* unmanaged<IMediaSourceStatics, IMseStreamSource, IMediaSource2*, int>)(
                (*lpVtbl)[8]
            )
        )(this, mediaSource, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateFromIMediaSource(
        [NativeTypeName("ABI::Windows::Media::Core::IMediaSource *")] IMediaSource mediaSource,
        [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2* result
    )
    {
        return (
            (delegate* unmanaged<IMediaSourceStatics, IMediaSource, IMediaSource2*, int>)(
                (*lpVtbl)[9]
            )
        )(this, mediaSource, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateFromStorageFile(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2* result
    )
    {
        return (
            (delegate* unmanaged<IMediaSourceStatics, IStorageFile, IMediaSource2*, int>)(
                (*lpVtbl)[10]
            )
        )(this, file, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateFromStream(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
            IRandomAccessStream stream,
        HSTRING contentType,
        [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2* result
    )
    {
        return (
            (delegate* unmanaged<
                IMediaSourceStatics,
                IRandomAccessStream,
                HSTRING,
                IMediaSource2*,
                int>)((*lpVtbl)[11])
        )(this, stream, contentType, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateFromStreamReference(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")]
            IRandomAccessStreamReference stream,
        HSTRING contentType,
        [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2* result
    )
    {
        return (
            (delegate* unmanaged<
                IMediaSourceStatics,
                IRandomAccessStreamReference,
                HSTRING,
                IMediaSource2*,
                int>)((*lpVtbl)[12])
        )(this, stream, contentType, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateFromUri(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2* result
    )
    {
        return (
            (delegate* unmanaged<IMediaSourceStatics, IUriRuntimeClass, IMediaSource2*, int>)(
                (*lpVtbl)[13]
            )
        )(this, uri, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromAdaptiveMediaSource(
            [NativeTypeName("ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSource *")]
                IAdaptiveMediaSource mediaSource,
            [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2* result
        );

        [VtblIndex(7)]
        HRESULT CreateFromMediaStreamSource(
            [NativeTypeName("ABI::Windows::Media::Core::IMediaStreamSource *")]
                IMediaStreamSource mediaSource,
            [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2* result
        );

        [VtblIndex(8)]
        HRESULT CreateFromMseStreamSource(
            [NativeTypeName("ABI::Windows::Media::Core::IMseStreamSource *")]
                IMseStreamSource mediaSource,
            [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2* result
        );

        [VtblIndex(9)]
        HRESULT CreateFromIMediaSource(
            [NativeTypeName("ABI::Windows::Media::Core::IMediaSource *")] IMediaSource mediaSource,
            [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2* result
        );

        [VtblIndex(10)]
        HRESULT CreateFromStorageFile(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2* result
        );

        [VtblIndex(11)]
        HRESULT CreateFromStream(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream *")]
                IRandomAccessStream stream,
            HSTRING contentType,
            [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2* result
        );

        [VtblIndex(12)]
        HRESULT CreateFromStreamReference(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")]
                IRandomAccessStreamReference stream,
            HSTRING contentType,
            [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2* result
        );

        [VtblIndex(13)]
        HRESULT CreateFromUri(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            [NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 **")] IMediaSource2* result
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
            "HRESULT (ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSource *, ABI::Windows::Media::Core::IMediaSource2 **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAdaptiveMediaSource,
            IMediaSource2*,
            int> CreateFromAdaptiveMediaSource;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::IMediaStreamSource *, ABI::Windows::Media::Core::IMediaSource2 **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaStreamSource,
            IMediaSource2*,
            int> CreateFromMediaStreamSource;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::IMseStreamSource *, ABI::Windows::Media::Core::IMediaSource2 **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMseStreamSource,
            IMediaSource2*,
            int> CreateFromMseStreamSource;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::IMediaSource *, ABI::Windows::Media::Core::IMediaSource2 **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaSource,
            IMediaSource2*,
            int> CreateFromIMediaSource;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Media::Core::IMediaSource2 **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageFile, IMediaSource2*, int> CreateFromStorageFile;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStream *, HSTRING, ABI::Windows::Media::Core::IMediaSource2 **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IRandomAccessStream,
            HSTRING,
            IMediaSource2*,
            int> CreateFromStream;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *, HSTRING, ABI::Windows::Media::Core::IMediaSource2 **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IRandomAccessStreamReference,
            HSTRING,
            IMediaSource2*,
            int> CreateFromStreamReference;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Media::Core::IMediaSource2 **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUriRuntimeClass, IMediaSource2*, int> CreateFromUri;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaSourceStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaSourceStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaSourceStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaSourceStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaSourceStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaSourceStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaSourceStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaSourceStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaSourceStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaSourceStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaSourceStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaSourceStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaSourceStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaSourceStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
