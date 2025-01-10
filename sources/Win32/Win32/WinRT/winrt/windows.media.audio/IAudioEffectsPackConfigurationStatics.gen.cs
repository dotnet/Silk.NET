// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("61C20413-530C-55FF-BA2B-8E68A9B56A04")]
[NativeTypeName("struct IAudioEffectsPackConfigurationStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioEffectsPackConfigurationStatics
    : IAudioEffectsPackConfigurationStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioEffectsPackConfigurationStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAudioEffectsPackConfigurationStatics, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioEffectsPackConfigurationStatics, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioEffectsPackConfigurationStatics, uint>)((*lpVtbl)[2]))(
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
            (delegate* unmanaged<IAudioEffectsPackConfigurationStatics, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IAudioEffectsPackConfigurationStatics, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IAudioEffectsPackConfigurationStatics, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetForDeviceId(
        HSTRING effectsPackId,
        HSTRING deviceId,
        [NativeTypeName("ABI::Windows::Media::Audio::IAudioEffectsPackConfiguration **")]
            IAudioEffectsPackConfiguration* result
    )
    {
        return (
            (delegate* unmanaged<
                IAudioEffectsPackConfigurationStatics,
                HSTRING,
                HSTRING,
                IAudioEffectsPackConfiguration*,
                int>)((*lpVtbl)[6])
        )(this, effectsPackId, deviceId, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsDeviceIdSupported(
        HSTRING effectsPackId,
        HSTRING deviceId,
        [NativeTypeName("boolean *")] byte* result
    )
    {
        return (
            (delegate* unmanaged<
                IAudioEffectsPackConfigurationStatics,
                HSTRING,
                HSTRING,
                byte*,
                int>)((*lpVtbl)[7])
        )(this, effectsPackId, deviceId, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetForDeviceId(
            HSTRING effectsPackId,
            HSTRING deviceId,
            [NativeTypeName("ABI::Windows::Media::Audio::IAudioEffectsPackConfiguration **")]
                IAudioEffectsPackConfiguration* result
        );

        [VtblIndex(7)]
        HRESULT IsDeviceIdSupported(
            HSTRING effectsPackId,
            HSTRING deviceId,
            [NativeTypeName("boolean *")] byte* result
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
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Media::Audio::IAudioEffectsPackConfiguration **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            IAudioEffectsPackConfiguration*,
            int> GetForDeviceId;

        [NativeTypeName("HRESULT (HSTRING, HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, byte*, int> IsDeviceIdSupported;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioEffectsPackConfigurationStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioEffectsPackConfigurationStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAudioEffectsPackConfigurationStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAudioEffectsPackConfigurationStatics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IAudioEffectsPackConfigurationStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioEffectsPackConfigurationStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioEffectsPackConfigurationStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IAudioEffectsPackConfigurationStatics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioEffectsPackConfigurationStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioEffectsPackConfigurationStatics(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IAudioEffectsPackConfigurationStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioEffectsPackConfigurationStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioEffectsPackConfigurationStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IAudioEffectsPackConfigurationStatics value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
