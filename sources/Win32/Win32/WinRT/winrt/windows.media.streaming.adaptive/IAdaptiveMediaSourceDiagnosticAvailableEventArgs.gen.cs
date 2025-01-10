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

[Guid("3AF64F06-6D9C-494A-B7A9-B3A5DEE6AD68")]
[NativeTypeName("struct IAdaptiveMediaSourceDiagnosticAvailableEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAdaptiveMediaSourceDiagnosticAvailableEventArgs
    : IAdaptiveMediaSourceDiagnosticAvailableEventArgs.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(
                ref Unsafe.AsRef(in IID_IAdaptiveMediaSourceDiagnosticAvailableEventArgs)
            );
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<
                IAdaptiveMediaSourceDiagnosticAvailableEventArgs,
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
            (delegate* unmanaged<IAdaptiveMediaSourceDiagnosticAvailableEventArgs, uint>)(
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
            (delegate* unmanaged<IAdaptiveMediaSourceDiagnosticAvailableEventArgs, uint>)(
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
                IAdaptiveMediaSourceDiagnosticAvailableEventArgs,
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
            (delegate* unmanaged<IAdaptiveMediaSourceDiagnosticAvailableEventArgs, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<
                IAdaptiveMediaSourceDiagnosticAvailableEventArgs,
                TrustLevel*,
                int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DiagnosticType(
        [NativeTypeName(
            "ABI::Windows::Media::Streaming::Adaptive::AdaptiveMediaSourceDiagnosticType *"
        )]
            AdaptiveMediaSourceDiagnosticType* value
    )
    {
        return (
            (delegate* unmanaged<
                IAdaptiveMediaSourceDiagnosticAvailableEventArgs,
                AdaptiveMediaSourceDiagnosticType*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_RequestId(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")]
            IReference<int>** value
    )
    {
        return (
            (delegate* unmanaged<
                IAdaptiveMediaSourceDiagnosticAvailableEventArgs,
                IReference<int>**,
                int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Position(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **"
        )]
            IReference<TimeSpan>** value
    )
    {
        return (
            (delegate* unmanaged<
                IAdaptiveMediaSourceDiagnosticAvailableEventArgs,
                IReference<TimeSpan>**,
                int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SegmentId(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")]
            IReference<ulong>** value
    )
    {
        return (
            (delegate* unmanaged<
                IAdaptiveMediaSourceDiagnosticAvailableEventArgs,
                IReference<ulong>**,
                int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ResourceType(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceResourceType_t **"
        )]
            IReference<AdaptiveMediaSourceResourceType>** value
    )
    {
        return (
            (delegate* unmanaged<
                IAdaptiveMediaSourceDiagnosticAvailableEventArgs,
                IReference<AdaptiveMediaSourceResourceType>**,
                int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ResourceUri(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass* value
    )
    {
        return (
            (delegate* unmanaged<
                IAdaptiveMediaSourceDiagnosticAvailableEventArgs,
                IUriRuntimeClass*,
                int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_ResourceByteRangeOffset(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")]
            IReference<ulong>** value
    )
    {
        return (
            (delegate* unmanaged<
                IAdaptiveMediaSourceDiagnosticAvailableEventArgs,
                IReference<ulong>**,
                int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_ResourceByteRangeLength(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")]
            IReference<ulong>** value
    )
    {
        return (
            (delegate* unmanaged<
                IAdaptiveMediaSourceDiagnosticAvailableEventArgs,
                IReference<ulong>**,
                int>)((*lpVtbl)[13])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Bitrate(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")]
            IReference<uint>** value
    )
    {
        return (
            (delegate* unmanaged<
                IAdaptiveMediaSourceDiagnosticAvailableEventArgs,
                IReference<uint>**,
                int>)((*lpVtbl)[14])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DiagnosticType(
            [NativeTypeName(
                "ABI::Windows::Media::Streaming::Adaptive::AdaptiveMediaSourceDiagnosticType *"
            )]
                AdaptiveMediaSourceDiagnosticType* value
        );

        [VtblIndex(7)]
        HRESULT get_RequestId(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_int_t **")]
                IReference<int>** value
        );

        [VtblIndex(8)]
        HRESULT get_Position(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **"
            )]
                IReference<TimeSpan>** value
        );

        [VtblIndex(9)]
        HRESULT get_SegmentId(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")]
                IReference<ulong>** value
        );

        [VtblIndex(10)]
        HRESULT get_ResourceType(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceResourceType_t **"
            )]
                IReference<AdaptiveMediaSourceResourceType>** value
        );

        [VtblIndex(11)]
        HRESULT get_ResourceUri(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")]
                IUriRuntimeClass* value
        );

        [VtblIndex(12)]
        HRESULT get_ResourceByteRangeOffset(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")]
                IReference<ulong>** value
        );

        [VtblIndex(13)]
        HRESULT get_ResourceByteRangeLength(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT64_t **")]
                IReference<ulong>** value
        );

        [VtblIndex(14)]
        HRESULT get_Bitrate(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")]
                IReference<uint>** value
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
            "HRESULT (ABI::Windows::Media::Streaming::Adaptive::AdaptiveMediaSourceDiagnosticType *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AdaptiveMediaSourceDiagnosticType*,
            int> get_DiagnosticType;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_int_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<int>**, int> get_RequestId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<TimeSpan>**, int> get_Position;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT64_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<ulong>**, int> get_SegmentId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CMedia__CStreaming__CAdaptive__CAdaptiveMediaSourceResourceType_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IReference<AdaptiveMediaSourceResourceType>**,
            int> get_ResourceType;

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
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<uint>**, int> get_Bitrate;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAdaptiveMediaSourceDiagnosticAvailableEventArgs"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAdaptiveMediaSourceDiagnosticAvailableEventArgs(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAdaptiveMediaSourceDiagnosticAvailableEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAdaptiveMediaSourceDiagnosticAvailableEventArgs(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IAdaptiveMediaSourceDiagnosticAvailableEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAdaptiveMediaSourceDiagnosticAvailableEventArgs"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAdaptiveMediaSourceDiagnosticAvailableEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IAdaptiveMediaSourceDiagnosticAvailableEventArgs value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAdaptiveMediaSourceDiagnosticAvailableEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAdaptiveMediaSourceDiagnosticAvailableEventArgs(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IAdaptiveMediaSourceDiagnosticAvailableEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAdaptiveMediaSourceDiagnosticAvailableEventArgs"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAdaptiveMediaSourceDiagnosticAvailableEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IAdaptiveMediaSourceDiagnosticAvailableEventArgs value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
