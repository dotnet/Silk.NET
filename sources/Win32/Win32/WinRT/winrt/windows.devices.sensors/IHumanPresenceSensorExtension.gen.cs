// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("3E526A71-2D1D-5D43-8A8E-A434A8242EF0")]
[NativeTypeName("struct IHumanPresenceSensorExtension : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHumanPresenceSensorExtension
    : IHumanPresenceSensorExtension.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHumanPresenceSensorExtension));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IHumanPresenceSensorExtension, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHumanPresenceSensorExtension, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHumanPresenceSensorExtension, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IHumanPresenceSensorExtension, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IHumanPresenceSensorExtension, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IHumanPresenceSensorExtension, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Initialize(HSTRING deviceInterface)
    {
        return ((delegate* unmanaged<IHumanPresenceSensorExtension, HSTRING, int>)((*lpVtbl)[6]))(
            this,
            deviceInterface
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged<IHumanPresenceSensorExtension, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ProcessReading(
        [NativeTypeName("ABI::Windows::Devices::Sensors::IHumanPresenceSensorReading *")]
            IHumanPresenceSensorReading reading,
        [NativeTypeName("ABI::Windows::Devices::Sensors::IHumanPresenceSensorReadingUpdate **")]
            IHumanPresenceSensorReadingUpdate* result
    )
    {
        return (
            (delegate* unmanaged<
                IHumanPresenceSensorExtension,
                IHumanPresenceSensorReading,
                IHumanPresenceSensorReadingUpdate*,
                int>)((*lpVtbl)[8])
        )(this, reading, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ProcessReadingTimeoutExpired(
        [NativeTypeName("ABI::Windows::Devices::Sensors::IHumanPresenceSensorReading *")]
            IHumanPresenceSensorReading reading
    )
    {
        return (
            (delegate* unmanaged<IHumanPresenceSensorExtension, IHumanPresenceSensorReading, int>)(
                (*lpVtbl)[9]
            )
        )(this, reading);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<IHumanPresenceSensorExtension, int>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Uninitialize()
    {
        return ((delegate* unmanaged<IHumanPresenceSensorExtension, int>)((*lpVtbl)[11]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IHumanPresenceSensorExtension, int>)((*lpVtbl)[12]))(this);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Initialize(HSTRING deviceInterface);

        [VtblIndex(7)]
        HRESULT Start();

        [VtblIndex(8)]
        HRESULT ProcessReading(
            [NativeTypeName("ABI::Windows::Devices::Sensors::IHumanPresenceSensorReading *")]
                IHumanPresenceSensorReading reading,
            [NativeTypeName("ABI::Windows::Devices::Sensors::IHumanPresenceSensorReadingUpdate **")]
                IHumanPresenceSensorReadingUpdate* result
        );

        [VtblIndex(9)]
        HRESULT ProcessReadingTimeoutExpired(
            [NativeTypeName("ABI::Windows::Devices::Sensors::IHumanPresenceSensorReading *")]
                IHumanPresenceSensorReading reading
        );

        [VtblIndex(10)]
        HRESULT Stop();

        [VtblIndex(11)]
        HRESULT Uninitialize();

        [VtblIndex(12)]
        HRESULT Reset();
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

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> Initialize;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Start;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sensors::IHumanPresenceSensorReading *, ABI::Windows::Devices::Sensors::IHumanPresenceSensorReadingUpdate **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHumanPresenceSensorReading,
            IHumanPresenceSensorReadingUpdate*,
            int> ProcessReading;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sensors::IHumanPresenceSensorReading *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHumanPresenceSensorReading,
            int> ProcessReadingTimeoutExpired;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Stop;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Uninitialize;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHumanPresenceSensorExtension"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHumanPresenceSensorExtension(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IHumanPresenceSensorExtension"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IHumanPresenceSensorExtension(Silk.NET.WinRT.IInspectable value)
    {
        return new IHumanPresenceSensorExtension(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHumanPresenceSensorExtension"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IHumanPresenceSensorExtension"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IHumanPresenceSensorExtension value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHumanPresenceSensorExtension"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHumanPresenceSensorExtension(Silk.NET.Windows.IUnknown value)
    {
        return new IHumanPresenceSensorExtension(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHumanPresenceSensorExtension"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHumanPresenceSensorExtension"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHumanPresenceSensorExtension value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
