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

[Guid("FDC8489A-6AD6-4CE4-B7F7-A99370DF7EE9")]
[NativeTypeName("struct IAudioNodeEmitterFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioNodeEmitterFactory
    : IAudioNodeEmitterFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioNodeEmitterFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioNodeEmitterFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAudioNodeEmitterFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioNodeEmitterFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAudioNodeEmitterFactory, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAudioNodeEmitterFactory, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAudioNodeEmitterFactory, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateAudioNodeEmitter(
        [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitterShape *")]
            IAudioNodeEmitterShape shape,
        [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitterDecayModel *")]
            IAudioNodeEmitterDecayModel decayModel,
        [NativeTypeName("ABI::Windows::Media::Audio::AudioNodeEmitterSettings")]
            AudioNodeEmitterSettings settings,
        [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitter **")]
            IAudioNodeEmitter* emitter
    )
    {
        return (
            (delegate* unmanaged<
                IAudioNodeEmitterFactory,
                IAudioNodeEmitterShape,
                IAudioNodeEmitterDecayModel,
                AudioNodeEmitterSettings,
                IAudioNodeEmitter*,
                int>)((*lpVtbl)[6])
        )(this, shape, decayModel, settings, emitter);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateAudioNodeEmitter(
            [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitterShape *")]
                IAudioNodeEmitterShape shape,
            [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitterDecayModel *")]
                IAudioNodeEmitterDecayModel decayModel,
            [NativeTypeName("ABI::Windows::Media::Audio::AudioNodeEmitterSettings")]
                AudioNodeEmitterSettings settings,
            [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitter **")]
                IAudioNodeEmitter* emitter
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
            "HRESULT (ABI::Windows::Media::Audio::IAudioNodeEmitterShape *, ABI::Windows::Media::Audio::IAudioNodeEmitterDecayModel *, ABI::Windows::Media::Audio::AudioNodeEmitterSettings, ABI::Windows::Media::Audio::IAudioNodeEmitter **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAudioNodeEmitterShape,
            IAudioNodeEmitterDecayModel,
            AudioNodeEmitterSettings,
            IAudioNodeEmitter*,
            int> CreateAudioNodeEmitter;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioNodeEmitterFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioNodeEmitterFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAudioNodeEmitterFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAudioNodeEmitterFactory(Silk.NET.WinRT.IInspectable value)
    {
        return new IAudioNodeEmitterFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioNodeEmitterFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioNodeEmitterFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAudioNodeEmitterFactory value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioNodeEmitterFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioNodeEmitterFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioNodeEmitterFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioNodeEmitterFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioNodeEmitterFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioNodeEmitterFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
