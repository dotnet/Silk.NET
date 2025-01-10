// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("FE3FC0B8-8529-411A-807B-48EDC2A0AB44")]
[NativeTypeName("struct ISmartCardEmulator2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardEmulator2 : ISmartCardEmulator2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmartCardEmulator2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISmartCardEmulator2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISmartCardEmulator2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISmartCardEmulator2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISmartCardEmulator2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISmartCardEmulator2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISmartCardEmulator2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_ApduReceived(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSmartCards__CSmartCardEmulator_Windows__CDevices__CSmartCards__CSmartCardEmulatorApduReceivedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardEmulator2,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[6])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_ApduReceived(EventRegistrationToken value)
    {
        return (
            (delegate* unmanaged<ISmartCardEmulator2, EventRegistrationToken, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_ConnectionDeactivated(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSmartCards__CSmartCardEmulator_Windows__CDevices__CSmartCards__CSmartCardEmulatorConnectionDeactivatedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardEmulator2,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[8])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_ConnectionDeactivated(EventRegistrationToken value)
    {
        return (
            (delegate* unmanaged<ISmartCardEmulator2, EventRegistrationToken, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged<ISmartCardEmulator2, int>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT IsHostCardEmulationSupported([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ISmartCardEmulator2, byte*, int>)((*lpVtbl)[11]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_ApduReceived(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSmartCards__CSmartCardEmulator_Windows__CDevices__CSmartCards__CSmartCardEmulatorApduReceivedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(7)]
        HRESULT remove_ApduReceived(EventRegistrationToken value);

        [VtblIndex(8)]
        HRESULT add_ConnectionDeactivated(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSmartCards__CSmartCardEmulator_Windows__CDevices__CSmartCards__CSmartCardEmulatorConnectionDeactivatedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(9)]
        HRESULT remove_ConnectionDeactivated(EventRegistrationToken value);

        [VtblIndex(10)]
        HRESULT Start();

        [VtblIndex(11)]
        HRESULT IsHostCardEmulationSupported([NativeTypeName("boolean *")] byte* value);
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
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSmartCards__CSmartCardEmulator_Windows__CDevices__CSmartCards__CSmartCardEmulatorApduReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_ApduReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_ApduReceived;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CSmartCards__CSmartCardEmulator_Windows__CDevices__CSmartCards__CSmartCardEmulatorConnectionDeactivatedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_ConnectionDeactivated;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_ConnectionDeactivated;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Start;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> IsHostCardEmulationSupported;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISmartCardEmulator2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISmartCardEmulator2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISmartCardEmulator2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISmartCardEmulator2(Silk.NET.WinRT.IInspectable value)
    {
        return new ISmartCardEmulator2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmartCardEmulator2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISmartCardEmulator2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISmartCardEmulator2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISmartCardEmulator2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISmartCardEmulator2(Silk.NET.Windows.IUnknown value)
    {
        return new ISmartCardEmulator2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmartCardEmulator2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISmartCardEmulator2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISmartCardEmulator2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
