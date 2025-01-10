// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.streaming.adaptive.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("C83FDFFD-44A9-47A2-BF96-03398B4BFAAF")]
[NativeTypeName("struct IAdaptiveMediaSourceDownloadRequestedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAdaptiveMediaSourceDownloadRequestedEventArgs
    : IAdaptiveMediaSourceDownloadRequestedEventArgs.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(
                ref Unsafe.AsRef(in IID_IAdaptiveMediaSourceDownloadRequestedEventArgs)
            );
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<
                IAdaptiveMediaSourceDownloadRequestedEventArgs,
                Guid*,
                void**,
                int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<IAdaptiveMediaSourceDownloadRequestedEventArgs, uint>)(
                (*lpVtbl)[1]
            )
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<IAdaptiveMediaSourceDownloadRequestedEventArgs, uint>)(
                (*lpVtbl)[2]
            )
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<
                IAdaptiveMediaSourceDownloadRequestedEventArgs,
                uint*,
                Guid**,
                int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IAdaptiveMediaSourceDownloadRequestedEventArgs, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IAdaptiveMediaSourceDownloadRequestedEventArgs, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ResourceType(
        [NativeTypeName(
            "ABI::Windows::Media::Streaming::Adaptive::AdaptiveMediaSourceResourceType *"
        )]
            AdaptiveMediaSourceResourceType* value
    )
    {
        return (
            (delegate* unmanaged<
                IAdaptiveMediaSourceDownloadRequestedEventArgs,
                AdaptiveMediaSourceResourceType*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ResourceUri(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass* value
    )
    {
        return (
            (delegate* unmanaged<
                IAdaptiveMediaSourceDownloadRequestedEventArgs,
                IUriRuntimeClass*,
                int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ResourceByteRangeOffset(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")]
            IReference<ulong>** value
    )
    {
        return (
            (delegate* unmanaged<
                IAdaptiveMediaSourceDownloadRequestedEventArgs,
                IReference<ulong>**,
                int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ResourceByteRangeLength(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")]
            IReference<ulong>** value
    )
    {
        return (
            (delegate* unmanaged<
                IAdaptiveMediaSourceDownloadRequestedEventArgs,
                IReference<ulong>**,
                int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Result(
        [NativeTypeName(
            "ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSourceDownloadResult **"
        )]
            IAdaptiveMediaSourceDownloadResult* value
    )
    {
        return (
            (delegate* unmanaged<
                IAdaptiveMediaSourceDownloadRequestedEventArgs,
                IAdaptiveMediaSourceDownloadResult*,
                int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetDeferral(
        [NativeTypeName(
            "ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSourceDownloadRequestedDeferral **"
        )]
            IAdaptiveMediaSourceDownloadRequestedDeferral* deferral
    )
    {
        return (
            (delegate* unmanaged<
                IAdaptiveMediaSourceDownloadRequestedEventArgs,
                IAdaptiveMediaSourceDownloadRequestedDeferral*,
                int>)((*lpVtbl)[11])
        )(this, deferral);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ResourceType(
            [NativeTypeName(
                "ABI::Windows::Media::Streaming::Adaptive::AdaptiveMediaSourceResourceType *"
            )]
                AdaptiveMediaSourceResourceType* value
        );

        [VtblIndex(7)]
        HRESULT get_ResourceUri(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")]
                IUriRuntimeClass* value
        );

        [VtblIndex(8)]
        HRESULT get_ResourceByteRangeOffset(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")]
                IReference<ulong>** value
        );

        [VtblIndex(9)]
        HRESULT get_ResourceByteRangeLength(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")]
                IReference<ulong>** value
        );

        [VtblIndex(10)]
        HRESULT get_Result(
            [NativeTypeName(
                "ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSourceDownloadResult **"
            )]
                IAdaptiveMediaSourceDownloadResult* value
        );

        [VtblIndex(11)]
        HRESULT GetDeferral(
            [NativeTypeName(
                "ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSourceDownloadRequestedDeferral **"
            )]
                IAdaptiveMediaSourceDownloadRequestedDeferral* deferral
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
            "HRESULT (ABI::Windows::Media::Streaming::Adaptive::AdaptiveMediaSourceResourceType *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AdaptiveMediaSourceResourceType*, int> get_ResourceType;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUriRuntimeClass*, int> get_ResourceUri;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT64_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<ulong>**, int> get_ResourceByteRangeOffset;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT64_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<ulong>**, int> get_ResourceByteRangeLength;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSourceDownloadResult **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAdaptiveMediaSourceDownloadResult*, int> get_Result;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Streaming::Adaptive::IAdaptiveMediaSourceDownloadRequestedDeferral **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAdaptiveMediaSourceDownloadRequestedDeferral*,
            int> GetDeferral;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAdaptiveMediaSourceDownloadRequestedEventArgs"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAdaptiveMediaSourceDownloadRequestedEventArgs(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAdaptiveMediaSourceDownloadRequestedEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAdaptiveMediaSourceDownloadRequestedEventArgs(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IAdaptiveMediaSourceDownloadRequestedEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAdaptiveMediaSourceDownloadRequestedEventArgs"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAdaptiveMediaSourceDownloadRequestedEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IAdaptiveMediaSourceDownloadRequestedEventArgs value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAdaptiveMediaSourceDownloadRequestedEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAdaptiveMediaSourceDownloadRequestedEventArgs(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IAdaptiveMediaSourceDownloadRequestedEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAdaptiveMediaSourceDownloadRequestedEventArgs"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAdaptiveMediaSourceDownloadRequestedEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IAdaptiveMediaSourceDownloadRequestedEventArgs value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
