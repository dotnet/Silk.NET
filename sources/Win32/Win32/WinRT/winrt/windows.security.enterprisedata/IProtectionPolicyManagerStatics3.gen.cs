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

[Guid("48FF9E8C-6A6F-4D9F-BCED-18AB537AA015")]
[NativeTypeName("struct IProtectionPolicyManagerStatics3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProtectionPolicyManagerStatics3
    : IProtectionPolicyManagerStatics3.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProtectionPolicyManagerStatics3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerStatics3, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IProtectionPolicyManagerStatics3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IProtectionPolicyManagerStatics3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerStatics3, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerStatics3, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerStatics3, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestAccessWithAuditingInfoAsync(
        HSTRING sourceIdentity,
        HSTRING targetIdentity,
        [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")]
            IProtectionPolicyAuditInfo auditInfo,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **"
        )]
            IAsyncOperation<ProtectionPolicyEvaluationResult>** result
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyManagerStatics3,
                HSTRING,
                HSTRING,
                IProtectionPolicyAuditInfo,
                IAsyncOperation<ProtectionPolicyEvaluationResult>**,
                int>)((*lpVtbl)[6])
        )(this, sourceIdentity, targetIdentity, auditInfo, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RequestAccessWithMessageAsync(
        HSTRING sourceIdentity,
        HSTRING targetIdentity,
        [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")]
            IProtectionPolicyAuditInfo auditInfo,
        HSTRING messageFromApp,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **"
        )]
            IAsyncOperation<ProtectionPolicyEvaluationResult>** result
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyManagerStatics3,
                HSTRING,
                HSTRING,
                IProtectionPolicyAuditInfo,
                HSTRING,
                IAsyncOperation<ProtectionPolicyEvaluationResult>**,
                int>)((*lpVtbl)[7])
        )(this, sourceIdentity, targetIdentity, auditInfo, messageFromApp, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RequestAccessForAppWithAuditingInfoAsync(
        HSTRING sourceIdentity,
        HSTRING appPackageFamilyName,
        [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")]
            IProtectionPolicyAuditInfo auditInfo,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **"
        )]
            IAsyncOperation<ProtectionPolicyEvaluationResult>** result
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyManagerStatics3,
                HSTRING,
                HSTRING,
                IProtectionPolicyAuditInfo,
                IAsyncOperation<ProtectionPolicyEvaluationResult>**,
                int>)((*lpVtbl)[8])
        )(this, sourceIdentity, appPackageFamilyName, auditInfo, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RequestAccessForAppWithMessageAsync(
        HSTRING sourceIdentity,
        HSTRING appPackageFamilyName,
        [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")]
            IProtectionPolicyAuditInfo auditInfo,
        HSTRING messageFromApp,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **"
        )]
            IAsyncOperation<ProtectionPolicyEvaluationResult>** result
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyManagerStatics3,
                HSTRING,
                HSTRING,
                IProtectionPolicyAuditInfo,
                HSTRING,
                IAsyncOperation<ProtectionPolicyEvaluationResult>**,
                int>)((*lpVtbl)[9])
        )(this, sourceIdentity, appPackageFamilyName, auditInfo, messageFromApp, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT LogAuditEvent(
        HSTRING sourceIdentity,
        HSTRING targetIdentity,
        [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")]
            IProtectionPolicyAuditInfo auditInfo
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyManagerStatics3,
                HSTRING,
                HSTRING,
                IProtectionPolicyAuditInfo,
                int>)((*lpVtbl)[10])
        )(this, sourceIdentity, targetIdentity, auditInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestAccessWithAuditingInfoAsync(
            HSTRING sourceIdentity,
            HSTRING targetIdentity,
            [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")]
                IProtectionPolicyAuditInfo auditInfo,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **"
            )]
                IAsyncOperation<ProtectionPolicyEvaluationResult>** result
        );

        [VtblIndex(7)]
        HRESULT RequestAccessWithMessageAsync(
            HSTRING sourceIdentity,
            HSTRING targetIdentity,
            [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")]
                IProtectionPolicyAuditInfo auditInfo,
            HSTRING messageFromApp,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **"
            )]
                IAsyncOperation<ProtectionPolicyEvaluationResult>** result
        );

        [VtblIndex(8)]
        HRESULT RequestAccessForAppWithAuditingInfoAsync(
            HSTRING sourceIdentity,
            HSTRING appPackageFamilyName,
            [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")]
                IProtectionPolicyAuditInfo auditInfo,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **"
            )]
                IAsyncOperation<ProtectionPolicyEvaluationResult>** result
        );

        [VtblIndex(9)]
        HRESULT RequestAccessForAppWithMessageAsync(
            HSTRING sourceIdentity,
            HSTRING appPackageFamilyName,
            [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")]
                IProtectionPolicyAuditInfo auditInfo,
            HSTRING messageFromApp,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **"
            )]
                IAsyncOperation<ProtectionPolicyEvaluationResult>** result
        );

        [VtblIndex(10)]
        HRESULT LogAuditEvent(
            HSTRING sourceIdentity,
            HSTRING targetIdentity,
            [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")]
                IProtectionPolicyAuditInfo auditInfo
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
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            IProtectionPolicyAuditInfo,
            IAsyncOperation<ProtectionPolicyEvaluationResult>**,
            int> RequestAccessWithAuditingInfoAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            IProtectionPolicyAuditInfo,
            HSTRING,
            IAsyncOperation<ProtectionPolicyEvaluationResult>**,
            int> RequestAccessWithMessageAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            IProtectionPolicyAuditInfo,
            IAsyncOperation<ProtectionPolicyEvaluationResult>**,
            int> RequestAccessForAppWithAuditingInfoAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            IProtectionPolicyAuditInfo,
            HSTRING,
            IAsyncOperation<ProtectionPolicyEvaluationResult>**,
            int> RequestAccessForAppWithMessageAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            IProtectionPolicyAuditInfo,
            int> LogAuditEvent;
    }

    /// <summary>Initializes a new instance of the <see cref = "IProtectionPolicyManagerStatics3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IProtectionPolicyManagerStatics3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IProtectionPolicyManagerStatics3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IProtectionPolicyManagerStatics3(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IProtectionPolicyManagerStatics3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProtectionPolicyManagerStatics3"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IProtectionPolicyManagerStatics3"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IProtectionPolicyManagerStatics3 value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IProtectionPolicyManagerStatics3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IProtectionPolicyManagerStatics3(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IProtectionPolicyManagerStatics3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProtectionPolicyManagerStatics3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IProtectionPolicyManagerStatics3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IProtectionPolicyManagerStatics3 value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
