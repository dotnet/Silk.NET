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

[Guid("46027FC0-D71B-45C7-8F14-6D9A0AE604E4")]
[NativeTypeName("struct IVideoMediaFrameFormat : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVideoMediaFrameFormat : IVideoMediaFrameFormat.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVideoMediaFrameFormat));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVideoMediaFrameFormat, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IVideoMediaFrameFormat, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVideoMediaFrameFormat, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IVideoMediaFrameFormat, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IVideoMediaFrameFormat, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IVideoMediaFrameFormat, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MediaFrameFormat(
        [NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameFormat **")]
            IMediaFrameFormat* value
    )
    {
        return (
            (delegate* unmanaged<IVideoMediaFrameFormat, IMediaFrameFormat*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DepthFormat(
        [NativeTypeName("ABI::Windows::Media::Capture::Frames::IDepthMediaFrameFormat **")]
            IDepthMediaFrameFormat* value
    )
    {
        return (
            (delegate* unmanaged<IVideoMediaFrameFormat, IDepthMediaFrameFormat*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Width([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IVideoMediaFrameFormat, uint*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Height([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IVideoMediaFrameFormat, uint*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MediaFrameFormat(
            [NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameFormat **")]
                IMediaFrameFormat* value
        );

        [VtblIndex(7)]
        HRESULT get_DepthFormat(
            [NativeTypeName("ABI::Windows::Media::Capture::Frames::IDepthMediaFrameFormat **")]
                IDepthMediaFrameFormat* value
        );

        [VtblIndex(8)]
        HRESULT get_Width([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(9)]
        HRESULT get_Height([NativeTypeName("UINT32 *")] uint* value);
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
            "HRESULT (ABI::Windows::Media::Capture::Frames::IMediaFrameFormat **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaFrameFormat*, int> get_MediaFrameFormat;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::Frames::IDepthMediaFrameFormat **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDepthMediaFrameFormat*, int> get_DepthFormat;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_Width;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_Height;
    }

    /// <summary>Initializes a new instance of the <see cref = "IVideoMediaFrameFormat"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IVideoMediaFrameFormat(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IVideoMediaFrameFormat"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IVideoMediaFrameFormat(Silk.NET.WinRT.IInspectable value)
    {
        return new IVideoMediaFrameFormat(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVideoMediaFrameFormat"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IVideoMediaFrameFormat"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IVideoMediaFrameFormat value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IVideoMediaFrameFormat"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IVideoMediaFrameFormat(Silk.NET.Windows.IUnknown value)
    {
        return new IVideoMediaFrameFormat(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVideoMediaFrameFormat"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IVideoMediaFrameFormat"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IVideoMediaFrameFormat value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
