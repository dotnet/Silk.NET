// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("20049D40-56D5-400E-A2EF-385599FEED49")]
[NativeTypeName("struct IAudioSystemEffectsPropertyChangeNotificationClient : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.22000.0")]
public unsafe partial struct IAudioSystemEffectsPropertyChangeNotificationClient
    : IAudioSystemEffectsPropertyChangeNotificationClient.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(
                ref Unsafe.AsRef(in IID_IAudioSystemEffectsPropertyChangeNotificationClient)
            );
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<
                IAudioSystemEffectsPropertyChangeNotificationClient,
                Guid*,
                void**,
                int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<IAudioSystemEffectsPropertyChangeNotificationClient, uint>)(
                (*lpVtbl)[1]
            )
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<IAudioSystemEffectsPropertyChangeNotificationClient, uint>)(
                (*lpVtbl)[2]
            )
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnPropertyChanged(
        AUDIO_SYSTEMEFFECTS_PROPERTYSTORE_TYPE type,
        [NativeTypeName("const PROPERTYKEY")] PROPERTYKEY key
    )
    {
        return (
            (delegate* unmanaged<
                IAudioSystemEffectsPropertyChangeNotificationClient,
                AUDIO_SYSTEMEFFECTS_PROPERTYSTORE_TYPE,
                PROPERTYKEY,
                int>)((*lpVtbl)[3])
        )(this, type, key);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnPropertyChanged(
            AUDIO_SYSTEMEFFECTS_PROPERTYSTORE_TYPE type,
            [NativeTypeName("const PROPERTYKEY")] PROPERTYKEY key
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

        [NativeTypeName(
            "HRESULT (AUDIO_SYSTEMEFFECTS_PROPERTYSTORE_TYPE, const PROPERTYKEY) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AUDIO_SYSTEMEFFECTS_PROPERTYSTORE_TYPE,
            PROPERTYKEY,
            int> OnPropertyChanged;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioSystemEffectsPropertyChangeNotificationClient"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioSystemEffectsPropertyChangeNotificationClient(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioSystemEffectsPropertyChangeNotificationClient"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioSystemEffectsPropertyChangeNotificationClient(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IAudioSystemEffectsPropertyChangeNotificationClient(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioSystemEffectsPropertyChangeNotificationClient"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioSystemEffectsPropertyChangeNotificationClient"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IAudioSystemEffectsPropertyChangeNotificationClient value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
