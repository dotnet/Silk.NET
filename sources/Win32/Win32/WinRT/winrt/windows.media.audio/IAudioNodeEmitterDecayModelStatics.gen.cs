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

[Guid("C7787CA8-F178-462F-BC81-8DD5CBE5DAE8")]
[NativeTypeName("struct IAudioNodeEmitterDecayModelStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioNodeEmitterDecayModelStatics
    : IAudioNodeEmitterDecayModelStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioNodeEmitterDecayModelStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAudioNodeEmitterDecayModelStatics, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioNodeEmitterDecayModelStatics, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioNodeEmitterDecayModelStatics, uint>)((*lpVtbl)[2]))(
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
            (delegate* unmanaged<IAudioNodeEmitterDecayModelStatics, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IAudioNodeEmitterDecayModelStatics, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IAudioNodeEmitterDecayModelStatics, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateNatural(
        double minGain,
        double maxGain,
        double unityGainDistance,
        double cutoffDistance,
        [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitterDecayModel **")]
            IAudioNodeEmitterDecayModel* decayModel
    )
    {
        return (
            (delegate* unmanaged<
                IAudioNodeEmitterDecayModelStatics,
                double,
                double,
                double,
                double,
                IAudioNodeEmitterDecayModel*,
                int>)((*lpVtbl)[6])
        )(this, minGain, maxGain, unityGainDistance, cutoffDistance, decayModel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateCustom(
        double minGain,
        double maxGain,
        [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitterDecayModel **")]
            IAudioNodeEmitterDecayModel* decayModel
    )
    {
        return (
            (delegate* unmanaged<
                IAudioNodeEmitterDecayModelStatics,
                double,
                double,
                IAudioNodeEmitterDecayModel*,
                int>)((*lpVtbl)[7])
        )(this, minGain, maxGain, decayModel);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateNatural(
            double minGain,
            double maxGain,
            double unityGainDistance,
            double cutoffDistance,
            [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitterDecayModel **")]
                IAudioNodeEmitterDecayModel* decayModel
        );

        [VtblIndex(7)]
        HRESULT CreateCustom(
            double minGain,
            double maxGain,
            [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitterDecayModel **")]
                IAudioNodeEmitterDecayModel* decayModel
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
            "HRESULT (DOUBLE, DOUBLE, DOUBLE, DOUBLE, ABI::Windows::Media::Audio::IAudioNodeEmitterDecayModel **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            double,
            double,
            double,
            double,
            IAudioNodeEmitterDecayModel*,
            int> CreateNatural;

        [NativeTypeName(
            "HRESULT (DOUBLE, DOUBLE, ABI::Windows::Media::Audio::IAudioNodeEmitterDecayModel **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            double,
            double,
            IAudioNodeEmitterDecayModel*,
            int> CreateCustom;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioNodeEmitterDecayModelStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioNodeEmitterDecayModelStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAudioNodeEmitterDecayModelStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAudioNodeEmitterDecayModelStatics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IAudioNodeEmitterDecayModelStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioNodeEmitterDecayModelStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioNodeEmitterDecayModelStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IAudioNodeEmitterDecayModelStatics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioNodeEmitterDecayModelStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioNodeEmitterDecayModelStatics(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IAudioNodeEmitterDecayModelStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioNodeEmitterDecayModelStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioNodeEmitterDecayModelStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IAudioNodeEmitterDecayModelStatics value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
