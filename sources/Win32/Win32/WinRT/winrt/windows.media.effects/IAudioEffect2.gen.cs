// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.effects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("06703CB0-757E-5757-8AF0-6BA58A8B2990")]
[NativeTypeName("struct IAudioEffect2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioEffect2 : IAudioEffect2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioEffect2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioEffect2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAudioEffect2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioEffect2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAudioEffect2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAudioEffect2, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAudioEffect2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AcousticEchoCancellationConfiguration(
        [NativeTypeName("ABI::Windows::Media::Effects::IAcousticEchoCancellationConfiguration **")]
            IAcousticEchoCancellationConfiguration* value
    )
    {
        return (
            (delegate* unmanaged<IAudioEffect2, IAcousticEchoCancellationConfiguration*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CanSetState([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAudioEffect2, byte*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_State(
        [NativeTypeName("ABI::Windows::Media::Effects::AudioEffectState *")] AudioEffectState* value
    )
    {
        return ((delegate* unmanaged<IAudioEffect2, AudioEffectState*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetState(
        [NativeTypeName("ABI::Windows::Media::Effects::AudioEffectState")] AudioEffectState newState
    )
    {
        return ((delegate* unmanaged<IAudioEffect2, AudioEffectState, int>)((*lpVtbl)[9]))(
            this,
            newState
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AcousticEchoCancellationConfiguration(
            [NativeTypeName(
                "ABI::Windows::Media::Effects::IAcousticEchoCancellationConfiguration **"
            )]
                IAcousticEchoCancellationConfiguration* value
        );

        [VtblIndex(7)]
        HRESULT get_CanSetState([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_State(
            [NativeTypeName("ABI::Windows::Media::Effects::AudioEffectState *")]
                AudioEffectState* value
        );

        [VtblIndex(9)]
        HRESULT SetState(
            [NativeTypeName("ABI::Windows::Media::Effects::AudioEffectState")]
                AudioEffectState newState
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
            "HRESULT (ABI::Windows::Media::Effects::IAcousticEchoCancellationConfiguration **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAcousticEchoCancellationConfiguration*,
            int> get_AcousticEchoCancellationConfiguration;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_CanSetState;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Effects::AudioEffectState *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AudioEffectState*, int> get_State;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Effects::AudioEffectState) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AudioEffectState, int> SetState;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioEffect2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioEffect2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAudioEffect2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAudioEffect2(Silk.NET.WinRT.IInspectable value)
    {
        return new IAudioEffect2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioEffect2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioEffect2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAudioEffect2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioEffect2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioEffect2(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioEffect2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioEffect2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioEffect2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioEffect2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
