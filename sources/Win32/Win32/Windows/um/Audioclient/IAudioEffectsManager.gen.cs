// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("4460B3AE-4B44-4527-8676-7548A8ACD260")]
[NativeTypeName("struct IAudioEffectsManager : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.22000.0")]
public unsafe partial struct IAudioEffectsManager : IAudioEffectsManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioEffectsManager));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioEffectsManager, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAudioEffectsManager, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioEffectsManager, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterAudioEffectsChangedNotificationCallback(
        IAudioEffectsChangedNotificationClient client
    )
    {
        return (
            (delegate* unmanaged<
                IAudioEffectsManager,
                IAudioEffectsChangedNotificationClient,
                int>)((*lpVtbl)[3])
        )(this, client);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnregisterAudioEffectsChangedNotificationCallback(
        IAudioEffectsChangedNotificationClient client
    )
    {
        return (
            (delegate* unmanaged<
                IAudioEffectsManager,
                IAudioEffectsChangedNotificationClient,
                int>)((*lpVtbl)[4])
        )(this, client);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetAudioEffects(
        AUDIO_EFFECT** effects,
        [NativeTypeName("UINT32 *")] uint* numEffects
    )
    {
        return (
            (delegate* unmanaged<IAudioEffectsManager, AUDIO_EFFECT**, uint*, int>)((*lpVtbl)[5])
        )(this, effects, numEffects);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetAudioEffectState(Guid effectId, AUDIO_EFFECT_STATE state)
    {
        return (
            (delegate* unmanaged<IAudioEffectsManager, Guid, AUDIO_EFFECT_STATE, int>)((*lpVtbl)[6])
        )(this, effectId, state);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RegisterAudioEffectsChangedNotificationCallback(
            IAudioEffectsChangedNotificationClient client
        );

        [VtblIndex(4)]
        HRESULT UnregisterAudioEffectsChangedNotificationCallback(
            IAudioEffectsChangedNotificationClient client
        );

        [VtblIndex(5)]
        HRESULT GetAudioEffects(
            AUDIO_EFFECT** effects,
            [NativeTypeName("UINT32 *")] uint* numEffects
        );

        [VtblIndex(6)]
        HRESULT SetAudioEffectState(Guid effectId, AUDIO_EFFECT_STATE state);
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
            "HRESULT (IAudioEffectsChangedNotificationClient *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAudioEffectsChangedNotificationClient,
            int> RegisterAudioEffectsChangedNotificationCallback;

        [NativeTypeName(
            "HRESULT (IAudioEffectsChangedNotificationClient *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAudioEffectsChangedNotificationClient,
            int> UnregisterAudioEffectsChangedNotificationCallback;

        [NativeTypeName("HRESULT (AUDIO_EFFECT **, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AUDIO_EFFECT**, uint*, int> GetAudioEffects;

        [NativeTypeName("HRESULT (GUID, AUDIO_EFFECT_STATE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, AUDIO_EFFECT_STATE, int> SetAudioEffectState;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioEffectsManager"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioEffectsManager(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioEffectsManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioEffectsManager(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioEffectsManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioEffectsManager"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioEffectsManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioEffectsManager value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
