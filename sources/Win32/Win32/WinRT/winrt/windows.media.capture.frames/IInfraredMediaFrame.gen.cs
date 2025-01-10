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

[Guid("3FD13503-004B-4F0E-91AC-465299B41658")]
[NativeTypeName("struct IInfraredMediaFrame : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IInfraredMediaFrame : IInfraredMediaFrame.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInfraredMediaFrame));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IInfraredMediaFrame, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IInfraredMediaFrame, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInfraredMediaFrame, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IInfraredMediaFrame, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IInfraredMediaFrame, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IInfraredMediaFrame, TrustLevel*, int>)((*lpVtbl)[5]))(
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
        return (
            (delegate* unmanaged<IInfraredMediaFrame, IMediaFrameReference*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_VideoMediaFrame(
        [NativeTypeName("ABI::Windows::Media::Capture::Frames::IVideoMediaFrame **")]
            IVideoMediaFrame* value
    )
    {
        return ((delegate* unmanaged<IInfraredMediaFrame, IVideoMediaFrame*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsIlluminated([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IInfraredMediaFrame, byte*, int>)((*lpVtbl)[8]))(this, value);
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
        HRESULT get_IsIlluminated([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsIlluminated;
    }

    /// <summary>Initializes a new instance of the <see cref = "IInfraredMediaFrame"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IInfraredMediaFrame(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IInfraredMediaFrame"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IInfraredMediaFrame(Silk.NET.WinRT.IInspectable value)
    {
        return new IInfraredMediaFrame(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IInfraredMediaFrame"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IInfraredMediaFrame"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IInfraredMediaFrame value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IInfraredMediaFrame"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IInfraredMediaFrame(Silk.NET.Windows.IUnknown value)
    {
        return new IInfraredMediaFrame(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IInfraredMediaFrame"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IInfraredMediaFrame"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IInfraredMediaFrame value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
