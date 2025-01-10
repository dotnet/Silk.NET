// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.capture.frames.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("F6B88641-F0DC-4044-8DC9-961CEDD05BAD")]
[NativeTypeName("struct IMediaFrameReference : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaFrameReference : IMediaFrameReference.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaFrameReference));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaFrameReference, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaFrameReference, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaFrameReference, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaFrameReference, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaFrameReference, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaFrameReference, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SourceKind(
        [NativeTypeName("ABI::Windows::Media::Capture::Frames::MediaFrameSourceKind *")]
            MediaFrameSourceKind* value
    )
    {
        return (
            (delegate* unmanaged<IMediaFrameReference, MediaFrameSourceKind*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Format(
        [NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameFormat **")]
            IMediaFrameFormat* value
    )
    {
        return ((delegate* unmanaged<IMediaFrameReference, IMediaFrameFormat*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SystemRelativeTime(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **"
        )]
            IReference<TimeSpan>** value
    )
    {
        return (
            (delegate* unmanaged<IMediaFrameReference, IReference<TimeSpan>**, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Duration(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
    )
    {
        return ((delegate* unmanaged<IMediaFrameReference, TimeSpan*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Properties(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIMapView_2_GUID_IInspectable_t **"
        )]
            IMapView<Guid, IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IMediaFrameReference, IMapView<Guid, IntPtr>**, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_BufferMediaFrame(
        [NativeTypeName("ABI::Windows::Media::Capture::Frames::IBufferMediaFrame **")]
            IBufferMediaFrame* value
    )
    {
        return (
            (delegate* unmanaged<IMediaFrameReference, IBufferMediaFrame*, int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_VideoMediaFrame(
        [NativeTypeName("ABI::Windows::Media::Capture::Frames::IVideoMediaFrame **")]
            IVideoMediaFrame* value
    )
    {
        return ((delegate* unmanaged<IMediaFrameReference, IVideoMediaFrame*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_CoordinateSystem(
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem **")]
            ISpatialCoordinateSystem* value
    )
    {
        return (
            (delegate* unmanaged<IMediaFrameReference, ISpatialCoordinateSystem*, int>)(
                (*lpVtbl)[13]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SourceKind(
            [NativeTypeName("ABI::Windows::Media::Capture::Frames::MediaFrameSourceKind *")]
                MediaFrameSourceKind* value
        );

        [VtblIndex(7)]
        HRESULT get_Format(
            [NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameFormat **")]
                IMediaFrameFormat* value
        );

        [VtblIndex(8)]
        HRESULT get_SystemRelativeTime(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **"
            )]
                IReference<TimeSpan>** value
        );

        [VtblIndex(9)]
        HRESULT get_Duration(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
        );

        [VtblIndex(10)]
        HRESULT get_Properties(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIMapView_2_GUID_IInspectable_t **"
            )]
                IMapView<Guid, IntPtr>** value
        );

        [VtblIndex(11)]
        HRESULT get_BufferMediaFrame(
            [NativeTypeName("ABI::Windows::Media::Capture::Frames::IBufferMediaFrame **")]
                IBufferMediaFrame* value
        );

        [VtblIndex(12)]
        HRESULT get_VideoMediaFrame(
            [NativeTypeName("ABI::Windows::Media::Capture::Frames::IVideoMediaFrame **")]
                IVideoMediaFrame* value
        );

        [VtblIndex(13)]
        HRESULT get_CoordinateSystem(
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem **")]
                ISpatialCoordinateSystem* value
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
            "HRESULT (ABI::Windows::Media::Capture::Frames::MediaFrameSourceKind *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MediaFrameSourceKind*, int> get_SourceKind;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::Frames::IMediaFrameFormat **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaFrameFormat*, int> get_Format;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CTimeSpan_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<TimeSpan>**, int> get_SystemRelativeTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan*, int> get_Duration;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIMapView_2_GUID_IInspectable_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMapView<Guid, IntPtr>**, int> get_Properties;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::Frames::IBufferMediaFrame **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBufferMediaFrame*, int> get_BufferMediaFrame;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::Frames::IVideoMediaFrame **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVideoMediaFrame*, int> get_VideoMediaFrame;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISpatialCoordinateSystem*, int> get_CoordinateSystem;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaFrameReference"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaFrameReference(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaFrameReference"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaFrameReference(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaFrameReference(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaFrameReference"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaFrameReference"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaFrameReference value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaFrameReference"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaFrameReference(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaFrameReference(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaFrameReference"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaFrameReference"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaFrameReference value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
