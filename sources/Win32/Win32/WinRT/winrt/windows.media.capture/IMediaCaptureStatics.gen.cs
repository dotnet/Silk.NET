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

[Guid("ACEF81FF-99ED-4645-965E-1925CFC63834")]
[NativeTypeName("struct IMediaCaptureStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaCaptureStatics : IMediaCaptureStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaCaptureStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaCaptureStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaCaptureStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaCaptureStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaCaptureStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaCaptureStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaCaptureStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsVideoProfileSupported(
        HSTRING videoDeviceId,
        [NativeTypeName("boolean *")] byte* value
    )
    {
        return ((delegate* unmanaged<IMediaCaptureStatics, HSTRING, byte*, int>)((*lpVtbl)[6]))(
            this,
            videoDeviceId,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FindAllVideoProfiles(
        HSTRING videoDeviceId,
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CMediaCaptureVideoProfile_t **"
        )]
            IVectorView<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IMediaCaptureStatics, HSTRING, IVectorView<IntPtr>**, int>)(
                (*lpVtbl)[7]
            )
        )(this, videoDeviceId, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FindConcurrentProfiles(
        HSTRING videoDeviceId,
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CMediaCaptureVideoProfile_t **"
        )]
            IVectorView<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IMediaCaptureStatics, HSTRING, IVectorView<IntPtr>**, int>)(
                (*lpVtbl)[8]
            )
        )(this, videoDeviceId, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT FindKnownVideoProfiles(
        HSTRING videoDeviceId,
        [NativeTypeName("ABI::Windows::Media::Capture::KnownVideoProfile")] KnownVideoProfile name,
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CMediaCaptureVideoProfile_t **"
        )]
            IVectorView<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCaptureStatics,
                HSTRING,
                KnownVideoProfile,
                IVectorView<IntPtr>**,
                int>)((*lpVtbl)[9])
        )(this, videoDeviceId, name, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT IsVideoProfileSupported(
            HSTRING videoDeviceId,
            [NativeTypeName("boolean *")] byte* value
        );

        [VtblIndex(7)]
        HRESULT FindAllVideoProfiles(
            HSTRING videoDeviceId,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CMediaCaptureVideoProfile_t **"
            )]
                IVectorView<IntPtr>** value
        );

        [VtblIndex(8)]
        HRESULT FindConcurrentProfiles(
            HSTRING videoDeviceId,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CMediaCaptureVideoProfile_t **"
            )]
                IVectorView<IntPtr>** value
        );

        [VtblIndex(9)]
        HRESULT FindKnownVideoProfiles(
            HSTRING videoDeviceId,
            [NativeTypeName("ABI::Windows::Media::Capture::KnownVideoProfile")]
                KnownVideoProfile name,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CMediaCaptureVideoProfile_t **"
            )]
                IVectorView<IntPtr>** value
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

        [NativeTypeName("HRESULT (HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, byte*, int> IsVideoProfileSupported;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CMediaCaptureVideoProfile_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IVectorView<IntPtr>**,
            int> FindAllVideoProfiles;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CMediaCaptureVideoProfile_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IVectorView<IntPtr>**,
            int> FindConcurrentProfiles;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Media::Capture::KnownVideoProfile, ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CMediaCaptureVideoProfile_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            KnownVideoProfile,
            IVectorView<IntPtr>**,
            int> FindKnownVideoProfiles;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaCaptureStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaCaptureStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaCaptureStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaCaptureStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaCaptureStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaCaptureStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaCaptureStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaCaptureStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaCaptureStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaCaptureStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaCaptureStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaCaptureStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaCaptureStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaCaptureStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
