// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.bluetooth.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("A193C0C7-4504-4F4A-9BA5-CD1054E5E065")]
[NativeTypeName("struct IBluetoothLEAppearanceStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBluetoothLEAppearanceStatics
    : IBluetoothLEAppearanceStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBluetoothLEAppearanceStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceStatics, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBluetoothLEAppearanceStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBluetoothLEAppearanceStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceStatics, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IBluetoothLEAppearanceStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IBluetoothLEAppearanceStatics, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FromRawValue(
        [NativeTypeName("UINT16")] ushort rawValue,
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothLEAppearance **")]
            IBluetoothLEAppearance* appearance
    )
    {
        return (
            (delegate* unmanaged<
                IBluetoothLEAppearanceStatics,
                ushort,
                IBluetoothLEAppearance*,
                int>)((*lpVtbl)[6])
        )(this, rawValue, appearance);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FromParts(
        [NativeTypeName("UINT16")] ushort appearanceCategory,
        [NativeTypeName("UINT16")] ushort appearanceSubCategory,
        [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothLEAppearance **")]
            IBluetoothLEAppearance* appearance
    )
    {
        return (
            (delegate* unmanaged<
                IBluetoothLEAppearanceStatics,
                ushort,
                ushort,
                IBluetoothLEAppearance*,
                int>)((*lpVtbl)[7])
        )(this, appearanceCategory, appearanceSubCategory, appearance);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FromRawValue(
            [NativeTypeName("UINT16")] ushort rawValue,
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothLEAppearance **")]
                IBluetoothLEAppearance* appearance
        );

        [VtblIndex(7)]
        HRESULT FromParts(
            [NativeTypeName("UINT16")] ushort appearanceCategory,
            [NativeTypeName("UINT16")] ushort appearanceSubCategory,
            [NativeTypeName("ABI::Windows::Devices::Bluetooth::IBluetoothLEAppearance **")]
                IBluetoothLEAppearance* appearance
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
            "HRESULT (UINT16, ABI::Windows::Devices::Bluetooth::IBluetoothLEAppearance **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort, IBluetoothLEAppearance*, int> FromRawValue;

        [NativeTypeName(
            "HRESULT (UINT16, UINT16, ABI::Windows::Devices::Bluetooth::IBluetoothLEAppearance **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort, ushort, IBluetoothLEAppearance*, int> FromParts;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBluetoothLEAppearanceStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBluetoothLEAppearanceStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBluetoothLEAppearanceStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBluetoothLEAppearanceStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IBluetoothLEAppearanceStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBluetoothLEAppearanceStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBluetoothLEAppearanceStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IBluetoothLEAppearanceStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBluetoothLEAppearanceStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBluetoothLEAppearanceStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IBluetoothLEAppearanceStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBluetoothLEAppearanceStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBluetoothLEAppearanceStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBluetoothLEAppearanceStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
