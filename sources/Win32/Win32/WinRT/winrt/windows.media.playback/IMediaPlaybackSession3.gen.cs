// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("7BA2B41A-A3E2-405F-B77B-A4812C238B66")]
[NativeTypeName("struct IMediaPlaybackSession3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaPlaybackSession3 : IMediaPlaybackSession3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaPlaybackSession3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaPlaybackSession3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaPlaybackSession3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaPlaybackSession3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaPlaybackSession3, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaPlaybackSession3, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaPlaybackSession3, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PlaybackRotation(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::MediaRotation *")]
            MediaRotation* value
    )
    {
        return ((delegate* unmanaged<IMediaPlaybackSession3, MediaRotation*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_PlaybackRotation(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::MediaRotation")] MediaRotation value
    )
    {
        return ((delegate* unmanaged<IMediaPlaybackSession3, MediaRotation, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetOutputDegradationPolicyState(
        [NativeTypeName(
            "ABI::Windows::Media::Playback::IMediaPlaybackSessionOutputDegradationPolicyState **"
        )]
            IMediaPlaybackSessionOutputDegradationPolicyState* value
    )
    {
        return (
            (delegate* unmanaged<
                IMediaPlaybackSession3,
                IMediaPlaybackSessionOutputDegradationPolicyState*,
                int>)((*lpVtbl)[8])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PlaybackRotation(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::MediaRotation *")]
                MediaRotation* value
        );

        [VtblIndex(7)]
        HRESULT put_PlaybackRotation(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::MediaRotation")]
                MediaRotation value
        );

        [VtblIndex(8)]
        HRESULT GetOutputDegradationPolicyState(
            [NativeTypeName(
                "ABI::Windows::Media::Playback::IMediaPlaybackSessionOutputDegradationPolicyState **"
            )]
                IMediaPlaybackSessionOutputDegradationPolicyState* value
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
            "HRESULT (ABI::Windows::Media::MediaProperties::MediaRotation *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MediaRotation*, int> get_PlaybackRotation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::MediaRotation) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MediaRotation, int> put_PlaybackRotation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Playback::IMediaPlaybackSessionOutputDegradationPolicyState **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaPlaybackSessionOutputDegradationPolicyState*,
            int> GetOutputDegradationPolicyState;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaPlaybackSession3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaPlaybackSession3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaPlaybackSession3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaPlaybackSession3(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaPlaybackSession3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaPlaybackSession3"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaPlaybackSession3"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaPlaybackSession3 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaPlaybackSession3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaPlaybackSession3(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaPlaybackSession3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaPlaybackSession3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaPlaybackSession3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaPlaybackSession3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
