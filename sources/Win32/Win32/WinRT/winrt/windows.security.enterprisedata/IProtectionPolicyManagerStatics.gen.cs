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

[Guid("C0BFFC66-8C3D-4D56-8804-C68F0AD32EC5")]
[NativeTypeName("struct IProtectionPolicyManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProtectionPolicyManagerStatics
    : IProtectionPolicyManagerStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProtectionPolicyManagerStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerStatics, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IProtectionPolicyManagerStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IProtectionPolicyManagerStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerStatics, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerStatics, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerStatics, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsIdentityManaged(HSTRING identity, [NativeTypeName("boolean *")] byte* result)
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerStatics, HSTRING, byte*, int>)(
                (*lpVtbl)[6]
            )
        )(this, identity, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryApplyProcessUIPolicy(
        HSTRING identity,
        [NativeTypeName("boolean *")] byte* result
    )
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerStatics, HSTRING, byte*, int>)(
                (*lpVtbl)[7]
            )
        )(this, identity, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ClearProcessUIPolicy()
    {
        return ((delegate* unmanaged<IProtectionPolicyManagerStatics, int>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateCurrentThreadNetworkContext(
        HSTRING identity,
        [NativeTypeName("ABI::Windows::Security::EnterpriseData::IThreadNetworkContext **")]
            IThreadNetworkContext* result
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyManagerStatics,
                HSTRING,
                IThreadNetworkContext*,
                int>)((*lpVtbl)[9])
        )(this, identity, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetPrimaryManagedIdentityForNetworkEndpointAsync(
        [NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName endpointHost,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
            IAsyncOperation<HSTRING>** result
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyManagerStatics,
                IHostName,
                IAsyncOperation<HSTRING>**,
                int>)((*lpVtbl)[10])
        )(this, endpointHost, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RevokeContent(HSTRING identity)
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerStatics, HSTRING, int>)((*lpVtbl)[11])
        )(this, identity);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetForCurrentView(
        [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyManager **")]
            IProtectionPolicyManager* result
    )
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerStatics, IProtectionPolicyManager*, int>)(
                (*lpVtbl)[12]
            )
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT add_ProtectedAccessSuspending(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIEventHandler_1_Windows__CSecurity__CEnterpriseData__CProtectedAccessSuspendingEventArgs_t *"
        )]
            IEventHandler<IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyManagerStatics,
                IEventHandler<IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[13])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT remove_ProtectedAccessSuspending(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerStatics, EventRegistrationToken, int>)(
                (*lpVtbl)[14]
            )
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT add_ProtectedAccessResumed(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIEventHandler_1_Windows__CSecurity__CEnterpriseData__CProtectedAccessResumedEventArgs_t *"
        )]
            IEventHandler<IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyManagerStatics,
                IEventHandler<IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[15])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT remove_ProtectedAccessResumed(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerStatics, EventRegistrationToken, int>)(
                (*lpVtbl)[16]
            )
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT add_ProtectedContentRevoked(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIEventHandler_1_Windows__CSecurity__CEnterpriseData__CProtectedContentRevokedEventArgs_t *"
        )]
            IEventHandler<IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyManagerStatics,
                IEventHandler<IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[17])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT remove_ProtectedContentRevoked(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerStatics, EventRegistrationToken, int>)(
                (*lpVtbl)[18]
            )
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT CheckAccess(
        HSTRING sourceIdentity,
        HSTRING targetIdentity,
        [NativeTypeName(
            "ABI::Windows::Security::EnterpriseData::ProtectionPolicyEvaluationResult *"
        )]
            ProtectionPolicyEvaluationResult* result
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyManagerStatics,
                HSTRING,
                HSTRING,
                ProtectionPolicyEvaluationResult*,
                int>)((*lpVtbl)[19])
        )(this, sourceIdentity, targetIdentity, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT RequestAccessAsync(
        HSTRING sourceIdentity,
        HSTRING targetIdentity,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **"
        )]
            IAsyncOperation<ProtectionPolicyEvaluationResult>** result
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyManagerStatics,
                HSTRING,
                HSTRING,
                IAsyncOperation<ProtectionPolicyEvaluationResult>**,
                int>)((*lpVtbl)[20])
        )(this, sourceIdentity, targetIdentity, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT IsIdentityManaged(HSTRING identity, [NativeTypeName("boolean *")] byte* result);

        [VtblIndex(7)]
        HRESULT TryApplyProcessUIPolicy(
            HSTRING identity,
            [NativeTypeName("boolean *")] byte* result
        );

        [VtblIndex(8)]
        HRESULT ClearProcessUIPolicy();

        [VtblIndex(9)]
        HRESULT CreateCurrentThreadNetworkContext(
            HSTRING identity,
            [NativeTypeName("ABI::Windows::Security::EnterpriseData::IThreadNetworkContext **")]
                IThreadNetworkContext* result
        );

        [VtblIndex(10)]
        HRESULT GetPrimaryManagedIdentityForNetworkEndpointAsync(
            [NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName endpointHost,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
                IAsyncOperation<HSTRING>** result
        );

        [VtblIndex(11)]
        HRESULT RevokeContent(HSTRING identity);

        [VtblIndex(12)]
        HRESULT GetForCurrentView(
            [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyManager **")]
                IProtectionPolicyManager* result
        );

        [VtblIndex(13)]
        HRESULT add_ProtectedAccessSuspending(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIEventHandler_1_Windows__CSecurity__CEnterpriseData__CProtectedAccessSuspendingEventArgs_t *"
            )]
                IEventHandler<IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(14)]
        HRESULT remove_ProtectedAccessSuspending(EventRegistrationToken token);

        [VtblIndex(15)]
        HRESULT add_ProtectedAccessResumed(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIEventHandler_1_Windows__CSecurity__CEnterpriseData__CProtectedAccessResumedEventArgs_t *"
            )]
                IEventHandler<IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(16)]
        HRESULT remove_ProtectedAccessResumed(EventRegistrationToken token);

        [VtblIndex(17)]
        HRESULT add_ProtectedContentRevoked(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIEventHandler_1_Windows__CSecurity__CEnterpriseData__CProtectedContentRevokedEventArgs_t *"
            )]
                IEventHandler<IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(18)]
        HRESULT remove_ProtectedContentRevoked(EventRegistrationToken token);

        [VtblIndex(19)]
        HRESULT CheckAccess(
            HSTRING sourceIdentity,
            HSTRING targetIdentity,
            [NativeTypeName(
                "ABI::Windows::Security::EnterpriseData::ProtectionPolicyEvaluationResult *"
            )]
                ProtectionPolicyEvaluationResult* result
        );

        [VtblIndex(20)]
        HRESULT RequestAccessAsync(
            HSTRING sourceIdentity,
            HSTRING targetIdentity,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **"
            )]
                IAsyncOperation<ProtectionPolicyEvaluationResult>** result
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

        [NativeTypeName("HRESULT (HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, byte*, int> IsIdentityManaged;

        [NativeTypeName("HRESULT (HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, byte*, int> TryApplyProcessUIPolicy;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ClearProcessUIPolicy;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Security::EnterpriseData::IThreadNetworkContext **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IThreadNetworkContext*,
            int> CreateCurrentThreadNetworkContext;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::IHostName *, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHostName,
            IAsyncOperation<HSTRING>**,
            int> GetPrimaryManagedIdentityForNetworkEndpointAsync;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> RevokeContent;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::EnterpriseData::IProtectionPolicyManager **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IProtectionPolicyManager*, int> GetForCurrentView;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_Windows__CSecurity__CEnterpriseData__CProtectedAccessSuspendingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IEventHandler<IntPtr>*,
            EventRegistrationToken*,
            int> add_ProtectedAccessSuspending;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_ProtectedAccessSuspending;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_Windows__CSecurity__CEnterpriseData__CProtectedAccessResumedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IEventHandler<IntPtr>*,
            EventRegistrationToken*,
            int> add_ProtectedAccessResumed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_ProtectedAccessResumed;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_Windows__CSecurity__CEnterpriseData__CProtectedContentRevokedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IEventHandler<IntPtr>*,
            EventRegistrationToken*,
            int> add_ProtectedContentRevoked;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_ProtectedContentRevoked;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Security::EnterpriseData::ProtectionPolicyEvaluationResult *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            ProtectionPolicyEvaluationResult*,
            int> CheckAccess;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            IAsyncOperation<ProtectionPolicyEvaluationResult>**,
            int> RequestAccessAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IProtectionPolicyManagerStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IProtectionPolicyManagerStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IProtectionPolicyManagerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IProtectionPolicyManagerStatics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IProtectionPolicyManagerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProtectionPolicyManagerStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IProtectionPolicyManagerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IProtectionPolicyManagerStatics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IProtectionPolicyManagerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IProtectionPolicyManagerStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IProtectionPolicyManagerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProtectionPolicyManagerStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IProtectionPolicyManagerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IProtectionPolicyManagerStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
