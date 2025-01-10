// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.gpio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("CB5EC0DE-6801-43FF-803D-4576628A8B26")]
[NativeTypeName("struct IGpioChangeCounter : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGpioChangeCounter : IGpioChangeCounter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGpioChangeCounter));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IGpioChangeCounter, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IGpioChangeCounter, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGpioChangeCounter, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IGpioChangeCounter, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IGpioChangeCounter, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IGpioChangeCounter, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_Polarity(
        [NativeTypeName("ABI::Windows::Devices::Gpio::GpioChangePolarity")] GpioChangePolarity value
    )
    {
        return ((delegate* unmanaged<IGpioChangeCounter, GpioChangePolarity, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Polarity(
        [NativeTypeName("ABI::Windows::Devices::Gpio::GpioChangePolarity *")]
            GpioChangePolarity* value
    )
    {
        return ((delegate* unmanaged<IGpioChangeCounter, GpioChangePolarity*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsStarted([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IGpioChangeCounter, byte*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged<IGpioChangeCounter, int>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<IGpioChangeCounter, int>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Read(
        [NativeTypeName("ABI::Windows::Devices::Gpio::GpioChangeCount *")] GpioChangeCount* value
    )
    {
        return ((delegate* unmanaged<IGpioChangeCounter, GpioChangeCount*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Reset(
        [NativeTypeName("ABI::Windows::Devices::Gpio::GpioChangeCount *")] GpioChangeCount* value
    )
    {
        return ((delegate* unmanaged<IGpioChangeCounter, GpioChangeCount*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_Polarity(
            [NativeTypeName("ABI::Windows::Devices::Gpio::GpioChangePolarity")]
                GpioChangePolarity value
        );

        [VtblIndex(7)]
        HRESULT get_Polarity(
            [NativeTypeName("ABI::Windows::Devices::Gpio::GpioChangePolarity *")]
                GpioChangePolarity* value
        );

        [VtblIndex(8)]
        HRESULT get_IsStarted([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT Start();

        [VtblIndex(10)]
        HRESULT Stop();

        [VtblIndex(11)]
        HRESULT Read(
            [NativeTypeName("ABI::Windows::Devices::Gpio::GpioChangeCount *")]
                GpioChangeCount* value
        );

        [VtblIndex(12)]
        HRESULT Reset(
            [NativeTypeName("ABI::Windows::Devices::Gpio::GpioChangeCount *")]
                GpioChangeCount* value
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
            "HRESULT (ABI::Windows::Devices::Gpio::GpioChangePolarity) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, GpioChangePolarity, int> put_Polarity;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Gpio::GpioChangePolarity *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, GpioChangePolarity*, int> get_Polarity;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsStarted;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Start;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Stop;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Gpio::GpioChangeCount *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, GpioChangeCount*, int> Read;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Gpio::GpioChangeCount *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, GpioChangeCount*, int> Reset;
    }

    /// <summary>Initializes a new instance of the <see cref = "IGpioChangeCounter"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IGpioChangeCounter(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IGpioChangeCounter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IGpioChangeCounter(Silk.NET.WinRT.IInspectable value)
    {
        return new IGpioChangeCounter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGpioChangeCounter"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IGpioChangeCounter"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IGpioChangeCounter value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IGpioChangeCounter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IGpioChangeCounter(Silk.NET.Windows.IUnknown value)
    {
        return new IGpioChangeCounter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGpioChangeCounter"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IGpioChangeCounter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IGpioChangeCounter value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
