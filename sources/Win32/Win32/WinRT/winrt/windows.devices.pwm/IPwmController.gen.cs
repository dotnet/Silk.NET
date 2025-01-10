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

[Guid("C45F5C85-D2E8-42CF-9BD6-CF5ED029E6A7")]
[NativeTypeName("struct IPwmController : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPwmController : IPwmController.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPwmController));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPwmController, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPwmController, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPwmController, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPwmController, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPwmController, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPwmController, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_PinCount([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IPwmController, int*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ActualFrequency(double* value)
    {
        return ((delegate* unmanaged<IPwmController, double*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetDesiredFrequency(double desiredFrequency, double* result)
    {
        return ((delegate* unmanaged<IPwmController, double, double*, int>)((*lpVtbl)[8]))(
            this,
            desiredFrequency,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MinFrequency(double* value)
    {
        return ((delegate* unmanaged<IPwmController, double*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MaxFrequency(double* value)
    {
        return ((delegate* unmanaged<IPwmController, double*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT OpenPin(
        [NativeTypeName("INT32")] int pinNumber,
        [NativeTypeName("ABI::Windows::Devices::Pwm::IPwmPin **")] IPwmPin* pin
    )
    {
        return ((delegate* unmanaged<IPwmController, int, IPwmPin*, int>)((*lpVtbl)[11]))(
            this,
            pinNumber,
            pin
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_PinCount([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT get_ActualFrequency(double* value);

        [VtblIndex(8)]
        HRESULT SetDesiredFrequency(double desiredFrequency, double* result);

        [VtblIndex(9)]
        HRESULT get_MinFrequency(double* value);

        [VtblIndex(10)]
        HRESULT get_MaxFrequency(double* value);

        [VtblIndex(11)]
        HRESULT OpenPin(
            [NativeTypeName("INT32")] int pinNumber,
            [NativeTypeName("ABI::Windows::Devices::Pwm::IPwmPin **")] IPwmPin* pin
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

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_PinCount;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_ActualFrequency;

        [NativeTypeName("HRESULT (DOUBLE, DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, double*, int> SetDesiredFrequency;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_MinFrequency;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_MaxFrequency;

        [NativeTypeName(
            "HRESULT (INT32, ABI::Windows::Devices::Pwm::IPwmPin **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, int, IPwmPin*, int> OpenPin;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPwmController"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPwmController(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPwmController"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPwmController(Silk.NET.WinRT.IInspectable value)
    {
        return new IPwmController(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPwmController"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPwmController"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPwmController value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPwmController"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPwmController(Silk.NET.Windows.IUnknown value)
    {
        return new IPwmController(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPwmController"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPwmController"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPwmController value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
