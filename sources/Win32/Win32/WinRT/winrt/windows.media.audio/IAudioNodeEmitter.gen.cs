// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("3676971D-880A-47B8-ADF7-1323A9D965BE")]
[NativeTypeName("struct IAudioNodeEmitter : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioNodeEmitter : IAudioNodeEmitter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioNodeEmitter));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioNodeEmitter, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAudioNodeEmitter, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioNodeEmitter, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAudioNodeEmitter, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAudioNodeEmitter, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAudioNodeEmitter, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Position(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value
    )
    {
        return ((delegate* unmanaged<IAudioNodeEmitter, Vector3*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Position(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value
    )
    {
        return ((delegate* unmanaged<IAudioNodeEmitter, Vector3, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Direction(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value
    )
    {
        return ((delegate* unmanaged<IAudioNodeEmitter, Vector3*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Direction(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value
    )
    {
        return ((delegate* unmanaged<IAudioNodeEmitter, Vector3, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Shape(
        [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitterShape **")]
            IAudioNodeEmitterShape* value
    )
    {
        return (
            (delegate* unmanaged<IAudioNodeEmitter, IAudioNodeEmitterShape*, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_DecayModel(
        [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitterDecayModel **")]
            IAudioNodeEmitterDecayModel* value
    )
    {
        return (
            (delegate* unmanaged<IAudioNodeEmitter, IAudioNodeEmitterDecayModel*, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Gain(double* value)
    {
        return ((delegate* unmanaged<IAudioNodeEmitter, double*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Gain(double value)
    {
        return ((delegate* unmanaged<IAudioNodeEmitter, double, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_DistanceScale(double* value)
    {
        return ((delegate* unmanaged<IAudioNodeEmitter, double*, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_DistanceScale(double value)
    {
        return ((delegate* unmanaged<IAudioNodeEmitter, double, int>)((*lpVtbl)[15]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_DopplerScale(double* value)
    {
        return ((delegate* unmanaged<IAudioNodeEmitter, double*, int>)((*lpVtbl)[16]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_DopplerScale(double value)
    {
        return ((delegate* unmanaged<IAudioNodeEmitter, double, int>)((*lpVtbl)[17]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_DopplerVelocity(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value
    )
    {
        return ((delegate* unmanaged<IAudioNodeEmitter, Vector3*, int>)((*lpVtbl)[18]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_DopplerVelocity(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value
    )
    {
        return ((delegate* unmanaged<IAudioNodeEmitter, Vector3, int>)((*lpVtbl)[19]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_IsDopplerDisabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAudioNodeEmitter, byte*, int>)((*lpVtbl)[20]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Position(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value
        );

        [VtblIndex(7)]
        HRESULT put_Position(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value
        );

        [VtblIndex(8)]
        HRESULT get_Direction(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value
        );

        [VtblIndex(9)]
        HRESULT put_Direction(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value
        );

        [VtblIndex(10)]
        HRESULT get_Shape(
            [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitterShape **")]
                IAudioNodeEmitterShape* value
        );

        [VtblIndex(11)]
        HRESULT get_DecayModel(
            [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitterDecayModel **")]
                IAudioNodeEmitterDecayModel* value
        );

        [VtblIndex(12)]
        HRESULT get_Gain(double* value);

        [VtblIndex(13)]
        HRESULT put_Gain(double value);

        [VtblIndex(14)]
        HRESULT get_DistanceScale(double* value);

        [VtblIndex(15)]
        HRESULT put_DistanceScale(double value);

        [VtblIndex(16)]
        HRESULT get_DopplerScale(double* value);

        [VtblIndex(17)]
        HRESULT put_DopplerScale(double value);

        [VtblIndex(18)]
        HRESULT get_DopplerVelocity(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value
        );

        [VtblIndex(19)]
        HRESULT put_DopplerVelocity(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value
        );

        [VtblIndex(20)]
        HRESULT get_IsDopplerDisabled([NativeTypeName("boolean *")] byte* value);
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
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector3 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector3*, int> get_Position;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector3) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector3, int> put_Position;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector3 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector3*, int> get_Direction;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector3) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector3, int> put_Direction;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Audio::IAudioNodeEmitterShape **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAudioNodeEmitterShape*, int> get_Shape;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Audio::IAudioNodeEmitterDecayModel **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAudioNodeEmitterDecayModel*, int> get_DecayModel;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_Gain;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_Gain;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_DistanceScale;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_DistanceScale;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_DopplerScale;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_DopplerScale;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector3 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector3*, int> get_DopplerVelocity;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector3) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector3, int> put_DopplerVelocity;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsDopplerDisabled;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioNodeEmitter"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioNodeEmitter(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAudioNodeEmitter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAudioNodeEmitter(Silk.NET.WinRT.IInspectable value)
    {
        return new IAudioNodeEmitter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioNodeEmitter"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioNodeEmitter"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAudioNodeEmitter value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioNodeEmitter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioNodeEmitter(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioNodeEmitter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioNodeEmitter"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioNodeEmitter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioNodeEmitter value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
