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

[Guid("2945C569-8975-4A51-9E1A-5F8A76EE51AF")]
[NativeTypeName("struct ISmartCardTriggerDetails2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardTriggerDetails2
    : ISmartCardTriggerDetails2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmartCardTriggerDetails2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISmartCardTriggerDetails2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISmartCardTriggerDetails2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISmartCardTriggerDetails2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISmartCardTriggerDetails2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISmartCardTriggerDetails2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISmartCardTriggerDetails2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Emulator(
        [NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardEmulator **")]
            ISmartCardEmulator* value
    )
    {
        return (
            (delegate* unmanaged<ISmartCardTriggerDetails2, ISmartCardEmulator*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryLaunchCurrentAppAsync(
        HSTRING arguments,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** result
    )
    {
        return (
            (delegate* unmanaged<ISmartCardTriggerDetails2, HSTRING, IAsyncOperation<byte>**, int>)(
                (*lpVtbl)[7]
            )
        )(this, arguments, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT TryLaunchCurrentAppWithBehaviorAsync(
        HSTRING arguments,
        [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardLaunchBehavior")]
            SmartCardLaunchBehavior behavior,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** result
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardTriggerDetails2,
                HSTRING,
                SmartCardLaunchBehavior,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[8])
        )(this, arguments, behavior, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Emulator(
            [NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardEmulator **")]
                ISmartCardEmulator* value
        );

        [VtblIndex(7)]
        HRESULT TryLaunchCurrentAppAsync(
            HSTRING arguments,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** result
        );

        [VtblIndex(8)]
        HRESULT TryLaunchCurrentAppWithBehaviorAsync(
            HSTRING arguments,
            [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardLaunchBehavior")]
                SmartCardLaunchBehavior behavior,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** result
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
            "HRESULT (ABI::Windows::Devices::SmartCards::ISmartCardEmulator **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISmartCardEmulator*, int> get_Emulator;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<byte>**,
            int> TryLaunchCurrentAppAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Devices::SmartCards::SmartCardLaunchBehavior, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            SmartCardLaunchBehavior,
            IAsyncOperation<byte>**,
            int> TryLaunchCurrentAppWithBehaviorAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISmartCardTriggerDetails2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISmartCardTriggerDetails2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISmartCardTriggerDetails2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISmartCardTriggerDetails2(Silk.NET.WinRT.IInspectable value)
    {
        return new ISmartCardTriggerDetails2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmartCardTriggerDetails2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISmartCardTriggerDetails2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISmartCardTriggerDetails2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISmartCardTriggerDetails2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISmartCardTriggerDetails2(Silk.NET.Windows.IUnknown value)
    {
        return new ISmartCardTriggerDetails2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmartCardTriggerDetails2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISmartCardTriggerDetails2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISmartCardTriggerDetails2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
