// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.enterprisedata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("B68F9A8C-39E0-4649-B2E4-070AB8A579B3")]
[NativeTypeName("struct IProtectionPolicyManagerStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProtectionPolicyManagerStatics2
    : IProtectionPolicyManagerStatics2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProtectionPolicyManagerStatics2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerStatics2, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IProtectionPolicyManagerStatics2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IProtectionPolicyManagerStatics2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerStatics2, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerStatics2, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerStatics2, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT HasContentBeenRevokedSince(
        HSTRING identity,
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime since,
        [NativeTypeName("boolean *")] byte* result
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyManagerStatics2,
                HSTRING,
                WinRTDateTime,
                byte*,
                int>)((*lpVtbl)[6])
        )(this, identity, since, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CheckAccessForApp(
        HSTRING sourceIdentity,
        HSTRING appPackageFamilyName,
        [NativeTypeName(
            "ABI::Windows::Security::EnterpriseData::ProtectionPolicyEvaluationResult *"
        )]
            ProtectionPolicyEvaluationResult* result
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyManagerStatics2,
                HSTRING,
                HSTRING,
                ProtectionPolicyEvaluationResult*,
                int>)((*lpVtbl)[7])
        )(this, sourceIdentity, appPackageFamilyName, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RequestAccessForAppAsync(
        HSTRING sourceIdentity,
        HSTRING appPackageFamilyName,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **"
        )]
            IAsyncOperation<ProtectionPolicyEvaluationResult>** result
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyManagerStatics2,
                HSTRING,
                HSTRING,
                IAsyncOperation<ProtectionPolicyEvaluationResult>**,
                int>)((*lpVtbl)[8])
        )(this, sourceIdentity, appPackageFamilyName, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetEnforcementLevel(
        HSTRING identity,
        [NativeTypeName("ABI::Windows::Security::EnterpriseData::EnforcementLevel *")]
            EnforcementLevel* value
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyManagerStatics2,
                HSTRING,
                EnforcementLevel*,
                int>)((*lpVtbl)[9])
        )(this, identity, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT IsUserDecryptionAllowed(
        HSTRING identity,
        [NativeTypeName("boolean *")] byte* value
    )
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerStatics2, HSTRING, byte*, int>)(
                (*lpVtbl)[10]
            )
        )(this, identity, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT IsProtectionUnderLockRequired(
        HSTRING identity,
        [NativeTypeName("boolean *")] byte* value
    )
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerStatics2, HSTRING, byte*, int>)(
                (*lpVtbl)[11]
            )
        )(this, identity, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_PolicyChanged(
        [NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")]
            IEventHandler<IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyManagerStatics2,
                IEventHandler<IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[12])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_PolicyChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerStatics2, EventRegistrationToken, int>)(
                (*lpVtbl)[13]
            )
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_IsProtectionEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IProtectionPolicyManagerStatics2, byte*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT HasContentBeenRevokedSince(
            HSTRING identity,
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime since,
            [NativeTypeName("boolean *")] byte* result
        );

        [VtblIndex(7)]
        HRESULT CheckAccessForApp(
            HSTRING sourceIdentity,
            HSTRING appPackageFamilyName,
            [NativeTypeName(
                "ABI::Windows::Security::EnterpriseData::ProtectionPolicyEvaluationResult *"
            )]
                ProtectionPolicyEvaluationResult* result
        );

        [VtblIndex(8)]
        HRESULT RequestAccessForAppAsync(
            HSTRING sourceIdentity,
            HSTRING appPackageFamilyName,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **"
            )]
                IAsyncOperation<ProtectionPolicyEvaluationResult>** result
        );

        [VtblIndex(9)]
        HRESULT GetEnforcementLevel(
            HSTRING identity,
            [NativeTypeName("ABI::Windows::Security::EnterpriseData::EnforcementLevel *")]
                EnforcementLevel* value
        );

        [VtblIndex(10)]
        HRESULT IsUserDecryptionAllowed(
            HSTRING identity,
            [NativeTypeName("boolean *")] byte* value
        );

        [VtblIndex(11)]
        HRESULT IsProtectionUnderLockRequired(
            HSTRING identity,
            [NativeTypeName("boolean *")] byte* value
        );

        [VtblIndex(12)]
        HRESULT add_PolicyChanged(
            [NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")]
                IEventHandler<IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(13)]
        HRESULT remove_PolicyChanged(EventRegistrationToken token);

        [VtblIndex(14)]
        HRESULT get_IsProtectionEnabled([NativeTypeName("boolean *")] byte* value);
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
            "HRESULT (HSTRING, ABI::Windows::Foundation::DateTime, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            WinRTDateTime,
            byte*,
            int> HasContentBeenRevokedSince;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Security::EnterpriseData::ProtectionPolicyEvaluationResult *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            ProtectionPolicyEvaluationResult*,
            int> CheckAccessForApp;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            IAsyncOperation<ProtectionPolicyEvaluationResult>**,
            int> RequestAccessForAppAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Security::EnterpriseData::EnforcementLevel *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, EnforcementLevel*, int> GetEnforcementLevel;

        [NativeTypeName("HRESULT (HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, byte*, int> IsUserDecryptionAllowed;

        [NativeTypeName("HRESULT (HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, byte*, int> IsProtectionUnderLockRequired;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IEventHandler<IntPtr>*,
            EventRegistrationToken*,
            int> add_PolicyChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_PolicyChanged;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsProtectionEnabled;
    }

    /// <summary>Initializes a new instance of the <see cref = "IProtectionPolicyManagerStatics2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IProtectionPolicyManagerStatics2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IProtectionPolicyManagerStatics2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IProtectionPolicyManagerStatics2(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IProtectionPolicyManagerStatics2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProtectionPolicyManagerStatics2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IProtectionPolicyManagerStatics2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IProtectionPolicyManagerStatics2 value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IProtectionPolicyManagerStatics2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IProtectionPolicyManagerStatics2(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IProtectionPolicyManagerStatics2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProtectionPolicyManagerStatics2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IProtectionPolicyManagerStatics2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IProtectionPolicyManagerStatics2 value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
