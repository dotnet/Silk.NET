// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("192601D5-147C-4769-B673-98A5EC8426CB")]
[NativeTypeName("struct IPhoneLineCellularDetails : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneLineCellularDetails
    : IPhoneLineCellularDetails.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPhoneLineCellularDetails));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPhoneLineCellularDetails, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPhoneLineCellularDetails, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPhoneLineCellularDetails, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPhoneLineCellularDetails, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPhoneLineCellularDetails, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPhoneLineCellularDetails, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SimState(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneSimState *")]
            PhoneSimState* value
    )
    {
        return (
            (delegate* unmanaged<IPhoneLineCellularDetails, PhoneSimState*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SimSlotIndex([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IPhoneLineCellularDetails, int*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsModemOn([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPhoneLineCellularDetails, byte*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_RegistrationRejectCode([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IPhoneLineCellularDetails, int*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetNetworkOperatorDisplayText(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Calls::PhoneLineNetworkOperatorDisplayTextLocation"
        )]
            PhoneLineNetworkOperatorDisplayTextLocation location,
        HSTRING* value
    )
    {
        return (
            (delegate* unmanaged<
                IPhoneLineCellularDetails,
                PhoneLineNetworkOperatorDisplayTextLocation,
                HSTRING*,
                int>)((*lpVtbl)[10])
        )(this, location, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SimState(
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneSimState *")]
                PhoneSimState* value
        );

        [VtblIndex(7)]
        HRESULT get_SimSlotIndex([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(8)]
        HRESULT get_IsModemOn([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_RegistrationRejectCode([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(10)]
        HRESULT GetNetworkOperatorDisplayText(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Calls::PhoneLineNetworkOperatorDisplayTextLocation"
            )]
                PhoneLineNetworkOperatorDisplayTextLocation location,
            HSTRING* value
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
            "HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneSimState *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PhoneSimState*, int> get_SimState;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_SimSlotIndex;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsModemOn;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_RegistrationRejectCode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneLineNetworkOperatorDisplayTextLocation, HSTRING *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            PhoneLineNetworkOperatorDisplayTextLocation,
            HSTRING*,
            int> GetNetworkOperatorDisplayText;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPhoneLineCellularDetails"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPhoneLineCellularDetails(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPhoneLineCellularDetails"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPhoneLineCellularDetails(Silk.NET.WinRT.IInspectable value)
    {
        return new IPhoneLineCellularDetails(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPhoneLineCellularDetails"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPhoneLineCellularDetails"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPhoneLineCellularDetails value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPhoneLineCellularDetails"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPhoneLineCellularDetails(Silk.NET.Windows.IUnknown value)
    {
        return new IPhoneLineCellularDetails(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPhoneLineCellularDetails"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPhoneLineCellularDetails"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPhoneLineCellularDetails value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
