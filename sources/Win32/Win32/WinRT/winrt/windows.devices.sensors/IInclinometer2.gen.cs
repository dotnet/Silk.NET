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

[Guid("029F3393-28B2-45F8-BB16-61E86A7FAE6E")]
[NativeTypeName("struct IInclinometer2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IInclinometer2 : IInclinometer2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInclinometer2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IInclinometer2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IInclinometer2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInclinometer2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IInclinometer2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IInclinometer2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IInclinometer2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_ReadingTransform(
        [NativeTypeName("ABI::Windows::Graphics::Display::DisplayOrientations")]
            DisplayOrientations value
    )
    {
        return ((delegate* unmanaged<IInclinometer2, DisplayOrientations, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ReadingTransform(
        [NativeTypeName("ABI::Windows::Graphics::Display::DisplayOrientations *")]
            DisplayOrientations* value
    )
    {
        return ((delegate* unmanaged<IInclinometer2, DisplayOrientations*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ReadingType(
        [NativeTypeName("ABI::Windows::Devices::Sensors::SensorReadingType *")]
            SensorReadingType* type
    )
    {
        return ((delegate* unmanaged<IInclinometer2, SensorReadingType*, int>)((*lpVtbl)[8]))(
            this,
            type
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_ReadingTransform(
            [NativeTypeName("ABI::Windows::Graphics::Display::DisplayOrientations")]
                DisplayOrientations value
        );

        [VtblIndex(7)]
        HRESULT get_ReadingTransform(
            [NativeTypeName("ABI::Windows::Graphics::Display::DisplayOrientations *")]
                DisplayOrientations* value
        );

        [VtblIndex(8)]
        HRESULT get_ReadingType(
            [NativeTypeName("ABI::Windows::Devices::Sensors::SensorReadingType *")]
                SensorReadingType* type
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
            "HRESULT (ABI::Windows::Graphics::Display::DisplayOrientations) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DisplayOrientations, int> put_ReadingTransform;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Display::DisplayOrientations *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DisplayOrientations*, int> get_ReadingTransform;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sensors::SensorReadingType *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SensorReadingType*, int> get_ReadingType;
    }

    /// <summary>Initializes a new instance of the <see cref = "IInclinometer2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IInclinometer2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IInclinometer2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IInclinometer2(Silk.NET.WinRT.IInspectable value)
    {
        return new IInclinometer2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IInclinometer2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IInclinometer2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IInclinometer2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IInclinometer2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IInclinometer2(Silk.NET.Windows.IUnknown value)
    {
        return new IInclinometer2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IInclinometer2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IInclinometer2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IInclinometer2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
