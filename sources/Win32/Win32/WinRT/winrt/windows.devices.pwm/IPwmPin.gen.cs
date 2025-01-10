// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.pwm.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("22972DC8-C6CF-4821-B7F9-C6454FB6AF79")]
[NativeTypeName("struct IPwmPin : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPwmPin : IPwmPin.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPwmPin));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPwmPin, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPwmPin, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPwmPin, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPwmPin, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPwmPin, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPwmPin, TrustLevel*, int>)((*lpVtbl)[5]))(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Controller(
        [NativeTypeName("ABI::Windows::Devices::Pwm::IPwmController **")] IPwmController* value
    )
    {
        return ((delegate* unmanaged<IPwmPin, IPwmController*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetActiveDutyCyclePercentage(double* result)
    {
        return ((delegate* unmanaged<IPwmPin, double*, int>)((*lpVtbl)[7]))(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetActiveDutyCyclePercentage(double dutyCyclePercentage)
    {
        return ((delegate* unmanaged<IPwmPin, double, int>)((*lpVtbl)[8]))(
            this,
            dutyCyclePercentage
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Polarity(
        [NativeTypeName("ABI::Windows::Devices::Pwm::PwmPulsePolarity *")] PwmPulsePolarity* value
    )
    {
        return ((delegate* unmanaged<IPwmPin, PwmPulsePolarity*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Polarity(
        [NativeTypeName("ABI::Windows::Devices::Pwm::PwmPulsePolarity")] PwmPulsePolarity value
    )
    {
        return ((delegate* unmanaged<IPwmPin, PwmPulsePolarity, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged<IPwmPin, int>)((*lpVtbl)[11]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<IPwmPin, int>)((*lpVtbl)[12]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_IsStarted([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPwmPin, byte*, int>)((*lpVtbl)[13]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Controller(
            [NativeTypeName("ABI::Windows::Devices::Pwm::IPwmController **")] IPwmController* value
        );

        [VtblIndex(7)]
        HRESULT GetActiveDutyCyclePercentage(double* result);

        [VtblIndex(8)]
        HRESULT SetActiveDutyCyclePercentage(double dutyCyclePercentage);

        [VtblIndex(9)]
        HRESULT get_Polarity(
            [NativeTypeName("ABI::Windows::Devices::Pwm::PwmPulsePolarity *")]
                PwmPulsePolarity* value
        );

        [VtblIndex(10)]
        HRESULT put_Polarity(
            [NativeTypeName("ABI::Windows::Devices::Pwm::PwmPulsePolarity")] PwmPulsePolarity value
        );

        [VtblIndex(11)]
        HRESULT Start();

        [VtblIndex(12)]
        HRESULT Stop();

        [VtblIndex(13)]
        HRESULT get_IsStarted([NativeTypeName("boolean *")] byte* value);
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
            "HRESULT (ABI::Windows::Devices::Pwm::IPwmController **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPwmController*, int> get_Controller;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> GetActiveDutyCyclePercentage;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> SetActiveDutyCyclePercentage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Pwm::PwmPulsePolarity *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PwmPulsePolarity*, int> get_Polarity;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Pwm::PwmPulsePolarity) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PwmPulsePolarity, int> put_Polarity;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Start;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Stop;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsStarted;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPwmPin"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPwmPin(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPwmPin"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPwmPin(Silk.NET.WinRT.IInspectable value)
    {
        return new IPwmPin(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPwmPin"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPwmPin"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPwmPin value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPwmPin"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPwmPin(Silk.NET.Windows.IUnknown value)
    {
        return new IPwmPin(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPwmPin"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPwmPin"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPwmPin value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
