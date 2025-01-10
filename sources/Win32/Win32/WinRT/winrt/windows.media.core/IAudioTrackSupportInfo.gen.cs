// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("178BEFF7-CC39-44A6-B951-4A5653F073FA")]
[NativeTypeName("struct IAudioTrackSupportInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioTrackSupportInfo : IAudioTrackSupportInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioTrackSupportInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioTrackSupportInfo, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAudioTrackSupportInfo, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioTrackSupportInfo, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAudioTrackSupportInfo, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAudioTrackSupportInfo, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAudioTrackSupportInfo, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DecoderStatus(
        [NativeTypeName("ABI::Windows::Media::Core::MediaDecoderStatus *")]
            MediaDecoderStatus* value
    )
    {
        return (
            (delegate* unmanaged<IAudioTrackSupportInfo, MediaDecoderStatus*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Degradation(
        [NativeTypeName("ABI::Windows::Media::Core::AudioDecoderDegradation *")]
            AudioDecoderDegradation* value
    )
    {
        return (
            (delegate* unmanaged<IAudioTrackSupportInfo, AudioDecoderDegradation*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DegradationReason(
        [NativeTypeName("ABI::Windows::Media::Core::AudioDecoderDegradationReason *")]
            AudioDecoderDegradationReason* value
    )
    {
        return (
            (delegate* unmanaged<IAudioTrackSupportInfo, AudioDecoderDegradationReason*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MediaSourceStatus(
        [NativeTypeName("ABI::Windows::Media::Core::MediaSourceStatus *")] MediaSourceStatus* value
    )
    {
        return (
            (delegate* unmanaged<IAudioTrackSupportInfo, MediaSourceStatus*, int>)((*lpVtbl)[9])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DecoderStatus(
            [NativeTypeName("ABI::Windows::Media::Core::MediaDecoderStatus *")]
                MediaDecoderStatus* value
        );

        [VtblIndex(7)]
        HRESULT get_Degradation(
            [NativeTypeName("ABI::Windows::Media::Core::AudioDecoderDegradation *")]
                AudioDecoderDegradation* value
        );

        [VtblIndex(8)]
        HRESULT get_DegradationReason(
            [NativeTypeName("ABI::Windows::Media::Core::AudioDecoderDegradationReason *")]
                AudioDecoderDegradationReason* value
        );

        [VtblIndex(9)]
        HRESULT get_MediaSourceStatus(
            [NativeTypeName("ABI::Windows::Media::Core::MediaSourceStatus *")]
                MediaSourceStatus* value
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
            "HRESULT (ABI::Windows::Media::Core::MediaDecoderStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MediaDecoderStatus*, int> get_DecoderStatus;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::AudioDecoderDegradation *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AudioDecoderDegradation*, int> get_Degradation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::AudioDecoderDegradationReason *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AudioDecoderDegradationReason*,
            int> get_DegradationReason;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Core::MediaSourceStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MediaSourceStatus*, int> get_MediaSourceStatus;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioTrackSupportInfo"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioTrackSupportInfo(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAudioTrackSupportInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAudioTrackSupportInfo(Silk.NET.WinRT.IInspectable value)
    {
        return new IAudioTrackSupportInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioTrackSupportInfo"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioTrackSupportInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAudioTrackSupportInfo value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioTrackSupportInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioTrackSupportInfo(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioTrackSupportInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioTrackSupportInfo"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioTrackSupportInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioTrackSupportInfo value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
