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

[Guid("00DD4CCB-32BD-4FE1-A013-7CC13CF5DBCF")]
[NativeTypeName("struct IVideoMediaFrame : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVideoMediaFrame : IVideoMediaFrame.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVideoMediaFrame));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVideoMediaFrame, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IVideoMediaFrame, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVideoMediaFrame, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IVideoMediaFrame, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IVideoMediaFrame, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IVideoMediaFrame, TrustLevel*, int>)((*lpVtbl)[5]))(
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
        return ((delegate* unmanaged<IVideoMediaFrame, IMediaFrameReference*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_VideoFormat(
        [NativeTypeName("ABI::Windows::Media::Capture::Frames::IVideoMediaFrameFormat **")]
            IVideoMediaFrameFormat* value
    )
    {
        return (
            (delegate* unmanaged<IVideoMediaFrame, IVideoMediaFrameFormat*, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SoftwareBitmap(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")]
            ISoftwareBitmap* value
    )
    {
        return ((delegate* unmanaged<IVideoMediaFrame, ISoftwareBitmap*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Direct3DSurface(
        [NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface **")]
            IDirect3DSurface* value
    )
    {
        return ((delegate* unmanaged<IVideoMediaFrame, IDirect3DSurface*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_CameraIntrinsics(
        [NativeTypeName("ABI::Windows::Media::Devices::Core::ICameraIntrinsics **")]
            ICameraIntrinsics* value
    )
    {
        return ((delegate* unmanaged<IVideoMediaFrame, ICameraIntrinsics*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_InfraredMediaFrame(
        [NativeTypeName("ABI::Windows::Media::Capture::Frames::IInfraredMediaFrame **")]
            IInfraredMediaFrame* value
    )
    {
        return ((delegate* unmanaged<IVideoMediaFrame, IInfraredMediaFrame*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_DepthMediaFrame(
        [NativeTypeName("ABI::Windows::Media::Capture::Frames::IDepthMediaFrame **")]
            IDepthMediaFrame* value
    )
    {
        return ((delegate* unmanaged<IVideoMediaFrame, IDepthMediaFrame*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetVideoFrame(
        [NativeTypeName("ABI::Windows::Media::IVideoFrame **")] IVideoFrame* value
    )
    {
        return ((delegate* unmanaged<IVideoMediaFrame, IVideoFrame*, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_FrameReference(
            [NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameReference **")]
                IMediaFrameReference* value
        );

        [VtblIndex(7)]
        HRESULT get_VideoFormat(
            [NativeTypeName("ABI::Windows::Media::Capture::Frames::IVideoMediaFrameFormat **")]
                IVideoMediaFrameFormat* value
        );

        [VtblIndex(8)]
        HRESULT get_SoftwareBitmap(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::ISoftwareBitmap **")]
                ISoftwareBitmap* value
        );

        [VtblIndex(9)]
        HRESULT get_Direct3DSurface(
            [NativeTypeName("ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface **")]
                IDirect3DSurface* value
        );

        [VtblIndex(10)]
        HRESULT get_CameraIntrinsics(
            [NativeTypeName("ABI::Windows::Media::Devices::Core::ICameraIntrinsics **")]
                ICameraIntrinsics* value
        );

        [VtblIndex(11)]
        HRESULT get_InfraredMediaFrame(
            [NativeTypeName("ABI::Windows::Media::Capture::Frames::IInfraredMediaFrame **")]
                IInfraredMediaFrame* value
        );

        [VtblIndex(12)]
        HRESULT get_DepthMediaFrame(
            [NativeTypeName("ABI::Windows::Media::Capture::Frames::IDepthMediaFrame **")]
                IDepthMediaFrame* value
        );

        [VtblIndex(13)]
        HRESULT GetVideoFrame(
            [NativeTypeName("ABI::Windows::Media::IVideoFrame **")] IVideoFrame* value
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
            "HRESULT (ABI::Windows::Media::Capture::Frames::IVideoMediaFrameFormat **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVideoMediaFrameFormat*, int> get_VideoFormat;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::ISoftwareBitmap **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISoftwareBitmap*, int> get_SoftwareBitmap;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::DirectX::Direct3D11::IDirect3DSurface **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDirect3DSurface*, int> get_Direct3DSurface;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::Core::ICameraIntrinsics **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICameraIntrinsics*, int> get_CameraIntrinsics;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::Frames::IInfraredMediaFrame **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IInfraredMediaFrame*, int> get_InfraredMediaFrame;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::Frames::IDepthMediaFrame **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDepthMediaFrame*, int> get_DepthMediaFrame;

        [NativeTypeName("HRESULT (ABI::Windows::Media::IVideoFrame **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IVideoFrame*, int> GetVideoFrame;
    }

    /// <summary>Initializes a new instance of the <see cref = "IVideoMediaFrame"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IVideoMediaFrame(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IVideoMediaFrame"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IVideoMediaFrame(Silk.NET.WinRT.IInspectable value)
    {
        return new IVideoMediaFrame(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVideoMediaFrame"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IVideoMediaFrame"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IVideoMediaFrame value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IVideoMediaFrame"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IVideoMediaFrame(Silk.NET.Windows.IUnknown value)
    {
        return new IVideoMediaFrame(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVideoMediaFrame"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IVideoMediaFrame"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IVideoMediaFrame value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
