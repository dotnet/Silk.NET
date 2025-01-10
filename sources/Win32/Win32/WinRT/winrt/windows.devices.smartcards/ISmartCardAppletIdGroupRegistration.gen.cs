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

[Guid("DF1208D1-31BB-5596-43B1-6D69A0257B3A")]
[NativeTypeName("struct ISmartCardAppletIdGroupRegistration : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardAppletIdGroupRegistration
    : ISmartCardAppletIdGroupRegistration.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmartCardAppletIdGroupRegistration));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISmartCardAppletIdGroupRegistration, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISmartCardAppletIdGroupRegistration, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISmartCardAppletIdGroupRegistration, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ISmartCardAppletIdGroupRegistration, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<ISmartCardAppletIdGroupRegistration, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ISmartCardAppletIdGroupRegistration, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ActivationPolicy(
        [NativeTypeName(
            "ABI::Windows::Devices::SmartCards::SmartCardAppletIdGroupActivationPolicy *"
        )]
            SmartCardAppletIdGroupActivationPolicy* value
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardAppletIdGroupRegistration,
                SmartCardAppletIdGroupActivationPolicy*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AppletIdGroup(
        [NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardAppletIdGroup **")]
            ISmartCardAppletIdGroup* value
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardAppletIdGroupRegistration,
                ISmartCardAppletIdGroup*,
                int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RequestActivationPolicyChangeAsync(
        [NativeTypeName(
            "ABI::Windows::Devices::SmartCards::SmartCardAppletIdGroupActivationPolicy"
        )]
            SmartCardAppletIdGroupActivationPolicy policy,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardActivationPolicyChangeResult_t **"
        )]
            IAsyncOperation<SmartCardActivationPolicyChangeResult>** result
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardAppletIdGroupRegistration,
                SmartCardAppletIdGroupActivationPolicy,
                IAsyncOperation<SmartCardActivationPolicyChangeResult>**,
                int>)((*lpVtbl)[8])
        )(this, policy, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Id(Guid* value)
    {
        return (
            (delegate* unmanaged<ISmartCardAppletIdGroupRegistration, Guid*, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetAutomaticResponseApdusAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CSmartCards__CSmartCardAutomaticResponseApdu_t *"
        )]
            IIterable<IntPtr>* apdus,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardAppletIdGroupRegistration,
                IIterable<IntPtr>*,
                IAsyncAction*,
                int>)((*lpVtbl)[10])
        )(this, apdus, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ActivationPolicy(
            [NativeTypeName(
                "ABI::Windows::Devices::SmartCards::SmartCardAppletIdGroupActivationPolicy *"
            )]
                SmartCardAppletIdGroupActivationPolicy* value
        );

        [VtblIndex(7)]
        HRESULT get_AppletIdGroup(
            [NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardAppletIdGroup **")]
                ISmartCardAppletIdGroup* value
        );

        [VtblIndex(8)]
        HRESULT RequestActivationPolicyChangeAsync(
            [NativeTypeName(
                "ABI::Windows::Devices::SmartCards::SmartCardAppletIdGroupActivationPolicy"
            )]
                SmartCardAppletIdGroupActivationPolicy policy,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardActivationPolicyChangeResult_t **"
            )]
                IAsyncOperation<SmartCardActivationPolicyChangeResult>** result
        );

        [VtblIndex(9)]
        HRESULT get_Id(Guid* value);

        [VtblIndex(10)]
        HRESULT SetAutomaticResponseApdusAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CSmartCards__CSmartCardAutomaticResponseApdu_t *"
            )]
                IIterable<IntPtr>* apdus,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
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
            "HRESULT (ABI::Windows::Devices::SmartCards::SmartCardAppletIdGroupActivationPolicy *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SmartCardAppletIdGroupActivationPolicy*,
            int> get_ActivationPolicy;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::SmartCards::ISmartCardAppletIdGroup **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISmartCardAppletIdGroup*, int> get_AppletIdGroup;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::SmartCards::SmartCardAppletIdGroupActivationPolicy, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardActivationPolicyChangeResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SmartCardAppletIdGroupActivationPolicy,
            IAsyncOperation<SmartCardActivationPolicyChangeResult>**,
            int> RequestActivationPolicyChangeAsync;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_Id;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CSmartCards__CSmartCardAutomaticResponseApdu_t *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<IntPtr>*,
            IAsyncAction*,
            int> SetAutomaticResponseApdusAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISmartCardAppletIdGroupRegistration"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISmartCardAppletIdGroupRegistration(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISmartCardAppletIdGroupRegistration"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISmartCardAppletIdGroupRegistration(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ISmartCardAppletIdGroupRegistration(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmartCardAppletIdGroupRegistration"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISmartCardAppletIdGroupRegistration"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ISmartCardAppletIdGroupRegistration value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISmartCardAppletIdGroupRegistration"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISmartCardAppletIdGroupRegistration(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ISmartCardAppletIdGroupRegistration(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmartCardAppletIdGroupRegistration"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISmartCardAppletIdGroupRegistration"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ISmartCardAppletIdGroupRegistration value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
