// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("574BD3D3-5F30-45CD-8A94-724FE5973084")]
[NativeTypeName("struct IDeviceAccessInformationStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDeviceAccessInformationStatics
    : IDeviceAccessInformationStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDeviceAccessInformationStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDeviceAccessInformationStatics, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDeviceAccessInformationStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDeviceAccessInformationStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IDeviceAccessInformationStatics, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IDeviceAccessInformationStatics, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IDeviceAccessInformationStatics, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromId(
        HSTRING deviceId,
        [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceAccessInformation **")]
            IDeviceAccessInformation* value
    )
    {
        return (
            (delegate* unmanaged<
                IDeviceAccessInformationStatics,
                HSTRING,
                IDeviceAccessInformation*,
                int>)((*lpVtbl)[6])
        )(this, deviceId, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromDeviceClassId(
        Guid deviceClassId,
        [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceAccessInformation **")]
            IDeviceAccessInformation* value
    )
    {
        return (
            (delegate* unmanaged<
                IDeviceAccessInformationStatics,
                Guid,
                IDeviceAccessInformation*,
                int>)((*lpVtbl)[7])
        )(this, deviceClassId, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateFromDeviceClass(
        [NativeTypeName("ABI::Windows::Devices::Enumeration::DeviceClass")] DeviceClass deviceClass,
        [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceAccessInformation **")]
            IDeviceAccessInformation* value
    )
    {
        return (
            (delegate* unmanaged<
                IDeviceAccessInformationStatics,
                DeviceClass,
                IDeviceAccessInformation*,
                int>)((*lpVtbl)[8])
        )(this, deviceClass, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromId(
            HSTRING deviceId,
            [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceAccessInformation **")]
                IDeviceAccessInformation* value
        );

        [VtblIndex(7)]
        HRESULT CreateFromDeviceClassId(
            Guid deviceClassId,
            [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceAccessInformation **")]
                IDeviceAccessInformation* value
        );

        [VtblIndex(8)]
        HRESULT CreateFromDeviceClass(
            [NativeTypeName("ABI::Windows::Devices::Enumeration::DeviceClass")]
                DeviceClass deviceClass,
            [NativeTypeName("ABI::Windows::Devices::Enumeration::IDeviceAccessInformation **")]
                IDeviceAccessInformation* value
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
            "HRESULT (HSTRING, ABI::Windows::Devices::Enumeration::IDeviceAccessInformation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IDeviceAccessInformation*, int> CreateFromId;

        [NativeTypeName(
            "HRESULT (GUID, ABI::Windows::Devices::Enumeration::IDeviceAccessInformation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid,
            IDeviceAccessInformation*,
            int> CreateFromDeviceClassId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Enumeration::DeviceClass, ABI::Windows::Devices::Enumeration::IDeviceAccessInformation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DeviceClass,
            IDeviceAccessInformation*,
            int> CreateFromDeviceClass;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDeviceAccessInformationStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDeviceAccessInformationStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDeviceAccessInformationStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDeviceAccessInformationStatics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IDeviceAccessInformationStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDeviceAccessInformationStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDeviceAccessInformationStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IDeviceAccessInformationStatics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDeviceAccessInformationStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDeviceAccessInformationStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IDeviceAccessInformationStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDeviceAccessInformationStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDeviceAccessInformationStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDeviceAccessInformationStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
