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

[Guid("8012AFEF-B691-49FF-83F2-C1E76EAAEA1B")]
[NativeTypeName("struct IMediaCaptureVideoProfileMediaDescription : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaCaptureVideoProfileMediaDescription
    : IMediaCaptureVideoProfileMediaDescription.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaCaptureVideoProfileMediaDescription));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMediaCaptureVideoProfileMediaDescription, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<IMediaCaptureVideoProfileMediaDescription, uint>)((*lpVtbl)[1])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<IMediaCaptureVideoProfileMediaDescription, uint>)((*lpVtbl)[2])
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
            (delegate* unmanaged<IMediaCaptureVideoProfileMediaDescription, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IMediaCaptureVideoProfileMediaDescription, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IMediaCaptureVideoProfileMediaDescription, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Width([NativeTypeName("UINT32 *")] uint* value)
    {
        return (
            (delegate* unmanaged<IMediaCaptureVideoProfileMediaDescription, uint*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Height([NativeTypeName("UINT32 *")] uint* value)
    {
        return (
            (delegate* unmanaged<IMediaCaptureVideoProfileMediaDescription, uint*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_FrameRate(double* value)
    {
        return (
            (delegate* unmanaged<IMediaCaptureVideoProfileMediaDescription, double*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete(
        "IsVariablePhotoSequenceSupported might not be available in the next major update following Windows 10, version 1709"
    )]
    public HRESULT get_IsVariablePhotoSequenceSupported([NativeTypeName("boolean *")] byte* value)
    {
        return (
            (delegate* unmanaged<IMediaCaptureVideoProfileMediaDescription, byte*, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete(
        "IsHdrVideoSupported might not be available in the next major update following Windows 10, version 1709"
    )]
    public HRESULT get_IsHdrVideoSupported([NativeTypeName("boolean *")] byte* value)
    {
        return (
            (delegate* unmanaged<IMediaCaptureVideoProfileMediaDescription, byte*, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Width([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT get_Height([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(8)]
        HRESULT get_FrameRate(double* value);

        [VtblIndex(9)]
        [Obsolete(
            "IsVariablePhotoSequenceSupported might not be available in the next major update following Windows 10, version 1709"
        )]
        HRESULT get_IsVariablePhotoSequenceSupported([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        [Obsolete(
            "IsHdrVideoSupported might not be available in the next major update following Windows 10, version 1709"
        )]
        HRESULT get_IsHdrVideoSupported([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_Width;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_Height;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_FrameRate;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete(
            "IsVariablePhotoSequenceSupported might not be available in the next major update following Windows 10, version 1709"
        )]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsVariablePhotoSequenceSupported;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete(
            "IsHdrVideoSupported might not be available in the next major update following Windows 10, version 1709"
        )]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsHdrVideoSupported;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaCaptureVideoProfileMediaDescription"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaCaptureVideoProfileMediaDescription(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaCaptureVideoProfileMediaDescription"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaCaptureVideoProfileMediaDescription(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IMediaCaptureVideoProfileMediaDescription(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaCaptureVideoProfileMediaDescription"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaCaptureVideoProfileMediaDescription"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IMediaCaptureVideoProfileMediaDescription value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaCaptureVideoProfileMediaDescription"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaCaptureVideoProfileMediaDescription(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IMediaCaptureVideoProfileMediaDescription(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaCaptureVideoProfileMediaDescription"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaCaptureVideoProfileMediaDescription"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IMediaCaptureVideoProfileMediaDescription value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
