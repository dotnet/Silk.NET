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

[Guid("D5A2E3B8-2626-4E94-B7B3-5308A0F64B1A")]
[NativeTypeName("struct IMediaCaptureInitializationSettings5 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaCaptureInitializationSettings5
    : IMediaCaptureInitializationSettings5.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaCaptureInitializationSettings5));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMediaCaptureInitializationSettings5, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMediaCaptureInitializationSettings5, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaCaptureInitializationSettings5, uint>)((*lpVtbl)[2]))(
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
            (delegate* unmanaged<IMediaCaptureInitializationSettings5, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IMediaCaptureInitializationSettings5, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IMediaCaptureInitializationSettings5, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SourceGroup(
        [NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameSourceGroup **")]
            IMediaFrameSourceGroup* value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCaptureInitializationSettings5,
                IMediaFrameSourceGroup*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_SourceGroup(
        [NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameSourceGroup *")]
            IMediaFrameSourceGroup value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCaptureInitializationSettings5,
                IMediaFrameSourceGroup,
                int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SharingMode(
        [NativeTypeName("ABI::Windows::Media::Capture::MediaCaptureSharingMode *")]
            MediaCaptureSharingMode* value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCaptureInitializationSettings5,
                MediaCaptureSharingMode*,
                int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_SharingMode(
        [NativeTypeName("ABI::Windows::Media::Capture::MediaCaptureSharingMode")]
            MediaCaptureSharingMode value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCaptureInitializationSettings5,
                MediaCaptureSharingMode,
                int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MemoryPreference(
        [NativeTypeName("ABI::Windows::Media::Capture::MediaCaptureMemoryPreference *")]
            MediaCaptureMemoryPreference* value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCaptureInitializationSettings5,
                MediaCaptureMemoryPreference*,
                int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_MemoryPreference(
        [NativeTypeName("ABI::Windows::Media::Capture::MediaCaptureMemoryPreference")]
            MediaCaptureMemoryPreference value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCaptureInitializationSettings5,
                MediaCaptureMemoryPreference,
                int>)((*lpVtbl)[11])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SourceGroup(
            [NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameSourceGroup **")]
                IMediaFrameSourceGroup* value
        );

        [VtblIndex(7)]
        HRESULT put_SourceGroup(
            [NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameSourceGroup *")]
                IMediaFrameSourceGroup value
        );

        [VtblIndex(8)]
        HRESULT get_SharingMode(
            [NativeTypeName("ABI::Windows::Media::Capture::MediaCaptureSharingMode *")]
                MediaCaptureSharingMode* value
        );

        [VtblIndex(9)]
        HRESULT put_SharingMode(
            [NativeTypeName("ABI::Windows::Media::Capture::MediaCaptureSharingMode")]
                MediaCaptureSharingMode value
        );

        [VtblIndex(10)]
        HRESULT get_MemoryPreference(
            [NativeTypeName("ABI::Windows::Media::Capture::MediaCaptureMemoryPreference *")]
                MediaCaptureMemoryPreference* value
        );

        [VtblIndex(11)]
        HRESULT put_MemoryPreference(
            [NativeTypeName("ABI::Windows::Media::Capture::MediaCaptureMemoryPreference")]
                MediaCaptureMemoryPreference value
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
            "HRESULT (ABI::Windows::Media::Capture::Frames::IMediaFrameSourceGroup **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaFrameSourceGroup*, int> get_SourceGroup;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::Frames::IMediaFrameSourceGroup *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaFrameSourceGroup, int> put_SourceGroup;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::MediaCaptureSharingMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MediaCaptureSharingMode*, int> get_SharingMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::MediaCaptureSharingMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MediaCaptureSharingMode, int> put_SharingMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::MediaCaptureMemoryPreference *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MediaCaptureMemoryPreference*, int> get_MemoryPreference;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::MediaCaptureMemoryPreference) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MediaCaptureMemoryPreference, int> put_MemoryPreference;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaCaptureInitializationSettings5"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaCaptureInitializationSettings5(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaCaptureInitializationSettings5"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaCaptureInitializationSettings5(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IMediaCaptureInitializationSettings5(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaCaptureInitializationSettings5"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaCaptureInitializationSettings5"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IMediaCaptureInitializationSettings5 value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaCaptureInitializationSettings5"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaCaptureInitializationSettings5(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IMediaCaptureInitializationSettings5(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaCaptureInitializationSettings5"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaCaptureInitializationSettings5"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IMediaCaptureInitializationSettings5 value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
