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

[Guid("47135E4F-8549-45C0-925B-80D35EFDB10A")]
[NativeTypeName("struct IDepthMediaFrame : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDepthMediaFrame : IDepthMediaFrame.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDepthMediaFrame));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDepthMediaFrame, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDepthMediaFrame, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDepthMediaFrame, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IDepthMediaFrame, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IDepthMediaFrame, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IDepthMediaFrame, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_FrameReference(
        [NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameReference **")]
            IMediaFrameReference* value
    )
    {
        return ((delegate* unmanaged<IDepthMediaFrame, IMediaFrameReference*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_VideoMediaFrame(
        [NativeTypeName("ABI::Windows::Media::Capture::Frames::IVideoMediaFrame **")]
            IVideoMediaFrame* value
    )
    {
        return ((delegate* unmanaged<IDepthMediaFrame, IVideoMediaFrame*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DepthFormat(
        [NativeTypeName("ABI::Windows::Media::Capture::Frames::IDepthMediaFrameFormat **")]
            IDepthMediaFrameFormat* value
    )
    {
        return (
            (delegate* unmanaged<IDepthMediaFrame, IDepthMediaFrameFormat*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT TryCreateCoordinateMapper(
        [NativeTypeName("ABI::Windows::Media::Devices::Core::ICameraIntrinsics *")]
            ICameraIntrinsics cameraIntrinsics,
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")]
            ISpatialCoordinateSystem coordinateSystem,
        [NativeTypeName("ABI::Windows::Media::Devices::Core::IDepthCorrelatedCoordinateMapper **")]
            IDepthCorrelatedCoordinateMapper* value
    )
    {
        return (
            (delegate* unmanaged<
                IDepthMediaFrame,
                ICameraIntrinsics,
                ISpatialCoordinateSystem,
                IDepthCorrelatedCoordinateMapper*,
                int>)((*lpVtbl)[9])
        )(this, cameraIntrinsics, coordinateSystem, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_FrameReference(
            [NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameReference **")]
                IMediaFrameReference* value
        );

        [VtblIndex(7)]
        HRESULT get_VideoMediaFrame(
            [NativeTypeName("ABI::Windows::Media::Capture::Frames::IVideoMediaFrame **")]
                IVideoMediaFrame* value
        );

        [VtblIndex(8)]
        HRESULT get_DepthFormat(
            [NativeTypeName("ABI::Windows::Media::Capture::Frames::IDepthMediaFrameFormat **")]
                IDepthMediaFrameFormat* value
        );

        [VtblIndex(9)]
        HRESULT TryCreateCoordinateMapper(
            [NativeTypeName("ABI::Windows::Media::Devices::Core::ICameraIntrinsics *")]
                ICameraIntrinsics cameraIntrinsics,
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *")]
                ISpatialCoordinateSystem coordinateSystem,
            [NativeTypeName(
                "ABI::Windows::Media::Devices::Core::IDepthCorrelatedCoordinateMapper **"
            )]
                IDepthCorrelatedCoordinateMapper* value
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
            "HRESULT (ABI::Windows::Media::Capture::Frames::IMediaFrameReference **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaFrameReference*, int> get_FrameReference;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::Frames::IVideoMediaFrame **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVideoMediaFrame*, int> get_VideoMediaFrame;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::Frames::IDepthMediaFrameFormat **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDepthMediaFrameFormat*, int> get_DepthFormat;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::Core::ICameraIntrinsics *, ABI::Windows::Perception::Spatial::ISpatialCoordinateSystem *, ABI::Windows::Media::Devices::Core::IDepthCorrelatedCoordinateMapper **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICameraIntrinsics,
            ISpatialCoordinateSystem,
            IDepthCorrelatedCoordinateMapper*,
            int> TryCreateCoordinateMapper;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDepthMediaFrame"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDepthMediaFrame(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDepthMediaFrame"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDepthMediaFrame(Silk.NET.WinRT.IInspectable value)
    {
        return new IDepthMediaFrame(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDepthMediaFrame"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDepthMediaFrame"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IDepthMediaFrame value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDepthMediaFrame"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDepthMediaFrame(Silk.NET.Windows.IUnknown value)
    {
        return new IDepthMediaFrame(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDepthMediaFrame"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDepthMediaFrame"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDepthMediaFrame value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
