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

[Guid("20B794DB-CCBD-490F-8C83-49CCB77AEA6C")]
[NativeTypeName("struct IProtectionPolicyManagerStatics4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProtectionPolicyManagerStatics4
    : IProtectionPolicyManagerStatics4.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProtectionPolicyManagerStatics4));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerStatics4, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IProtectionPolicyManagerStatics4, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IProtectionPolicyManagerStatics4, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerStatics4, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerStatics4, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerStatics4, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsRoamableProtectionEnabled(
        HSTRING identity,
        [NativeTypeName("boolean *")] byte* value
    )
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerStatics4, HSTRING, byte*, int>)(
                (*lpVtbl)[6]
            )
        )(this, identity, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RequestAccessWithBehaviorAsync(
        HSTRING sourceIdentity,
        HSTRING targetIdentity,
        [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")]
            IProtectionPolicyAuditInfo auditInfo,
        HSTRING messageFromApp,
        [NativeTypeName(
            "ABI::Windows::Security::EnterpriseData::ProtectionPolicyRequestAccessBehavior"
        )]
            ProtectionPolicyRequestAccessBehavior behavior,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **"
        )]
            IAsyncOperation<ProtectionPolicyEvaluationResult>** result
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyManagerStatics4,
                HSTRING,
                HSTRING,
                IProtectionPolicyAuditInfo,
                HSTRING,
                ProtectionPolicyRequestAccessBehavior,
                IAsyncOperation<ProtectionPolicyEvaluationResult>**,
                int>)((*lpVtbl)[7])
        )(this, sourceIdentity, targetIdentity, auditInfo, messageFromApp, behavior, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RequestAccessForAppWithBehaviorAsync(
        HSTRING sourceIdentity,
        HSTRING appPackageFamilyName,
        [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")]
            IProtectionPolicyAuditInfo auditInfo,
        HSTRING messageFromApp,
        [NativeTypeName(
            "ABI::Windows::Security::EnterpriseData::ProtectionPolicyRequestAccessBehavior"
        )]
            ProtectionPolicyRequestAccessBehavior behavior,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **"
        )]
            IAsyncOperation<ProtectionPolicyEvaluationResult>** result
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyManagerStatics4,
                HSTRING,
                HSTRING,
                IProtectionPolicyAuditInfo,
                HSTRING,
                ProtectionPolicyRequestAccessBehavior,
                IAsyncOperation<ProtectionPolicyEvaluationResult>**,
                int>)((*lpVtbl)[8])
        )(this, sourceIdentity, appPackageFamilyName, auditInfo, messageFromApp, behavior, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RequestAccessToFilesForAppAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *"
        )]
            IIterable<IntPtr>* sourceItemList,
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
                IProtectionPolicyManagerStatics4,
                IIterable<IntPtr>*,
                HSTRING,
                IProtectionPolicyAuditInfo,
                IAsyncOperation<ProtectionPolicyEvaluationResult>**,
                int>)((*lpVtbl)[9])
        )(this, sourceItemList, appPackageFamilyName, auditInfo, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RequestAccessToFilesForAppWithMessageAndBehaviorAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *"
        )]
            IIterable<IntPtr>* sourceItemList,
        HSTRING appPackageFamilyName,
        [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")]
            IProtectionPolicyAuditInfo auditInfo,
        HSTRING messageFromApp,
        [NativeTypeName(
            "ABI::Windows::Security::EnterpriseData::ProtectionPolicyRequestAccessBehavior"
        )]
            ProtectionPolicyRequestAccessBehavior behavior,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **"
        )]
            IAsyncOperation<ProtectionPolicyEvaluationResult>** result
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyManagerStatics4,
                IIterable<IntPtr>*,
                HSTRING,
                IProtectionPolicyAuditInfo,
                HSTRING,
                ProtectionPolicyRequestAccessBehavior,
                IAsyncOperation<ProtectionPolicyEvaluationResult>**,
                int>)((*lpVtbl)[10])
        )(this, sourceItemList, appPackageFamilyName, auditInfo, messageFromApp, behavior, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RequestAccessToFilesForProcessAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *"
        )]
            IIterable<IntPtr>* sourceItemList,
        [NativeTypeName("UINT32")] uint processId,
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
                IProtectionPolicyManagerStatics4,
                IIterable<IntPtr>*,
                uint,
                IProtectionPolicyAuditInfo,
                IAsyncOperation<ProtectionPolicyEvaluationResult>**,
                int>)((*lpVtbl)[11])
        )(this, sourceItemList, processId, auditInfo, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT RequestAccessToFilesForProcessWithMessageAndBehaviorAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *"
        )]
            IIterable<IntPtr>* sourceItemList,
        [NativeTypeName("UINT32")] uint processId,
        [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")]
            IProtectionPolicyAuditInfo auditInfo,
        HSTRING messageFromApp,
        [NativeTypeName(
            "ABI::Windows::Security::EnterpriseData::ProtectionPolicyRequestAccessBehavior"
        )]
            ProtectionPolicyRequestAccessBehavior behavior,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **"
        )]
            IAsyncOperation<ProtectionPolicyEvaluationResult>** result
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyManagerStatics4,
                IIterable<IntPtr>*,
                uint,
                IProtectionPolicyAuditInfo,
                HSTRING,
                ProtectionPolicyRequestAccessBehavior,
                IAsyncOperation<ProtectionPolicyEvaluationResult>**,
                int>)((*lpVtbl)[12])
        )(this, sourceItemList, processId, auditInfo, messageFromApp, behavior, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT IsFileProtectionRequiredAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem target,
        HSTRING identity,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** result
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyManagerStatics4,
                IStorageItem,
                HSTRING,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[13])
        )(this, target, identity, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT IsFileProtectionRequiredForNewFileAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder parentFolder,
        HSTRING identity,
        HSTRING desiredName,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** result
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyManagerStatics4,
                IStorageFolder,
                HSTRING,
                HSTRING,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[14])
        )(this, parentFolder, identity, desiredName, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_PrimaryManagedIdentity(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerStatics4, HSTRING*, int>)((*lpVtbl)[15])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetPrimaryManagedIdentityForIdentity(HSTRING identity, HSTRING* value)
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerStatics4, HSTRING, HSTRING*, int>)(
                (*lpVtbl)[16]
            )
        )(this, identity, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT IsRoamableProtectionEnabled(
            HSTRING identity,
            [NativeTypeName("boolean *")] byte* value
        );

        [VtblIndex(7)]
        HRESULT RequestAccessWithBehaviorAsync(
            HSTRING sourceIdentity,
            HSTRING targetIdentity,
            [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")]
                IProtectionPolicyAuditInfo auditInfo,
            HSTRING messageFromApp,
            [NativeTypeName(
                "ABI::Windows::Security::EnterpriseData::ProtectionPolicyRequestAccessBehavior"
            )]
                ProtectionPolicyRequestAccessBehavior behavior,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **"
            )]
                IAsyncOperation<ProtectionPolicyEvaluationResult>** result
        );

        [VtblIndex(8)]
        HRESULT RequestAccessForAppWithBehaviorAsync(
            HSTRING sourceIdentity,
            HSTRING appPackageFamilyName,
            [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")]
                IProtectionPolicyAuditInfo auditInfo,
            HSTRING messageFromApp,
            [NativeTypeName(
                "ABI::Windows::Security::EnterpriseData::ProtectionPolicyRequestAccessBehavior"
            )]
                ProtectionPolicyRequestAccessBehavior behavior,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **"
            )]
                IAsyncOperation<ProtectionPolicyEvaluationResult>** result
        );

        [VtblIndex(9)]
        HRESULT RequestAccessToFilesForAppAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *"
            )]
                IIterable<IntPtr>* sourceItemList,
            HSTRING appPackageFamilyName,
            [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")]
                IProtectionPolicyAuditInfo auditInfo,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **"
            )]
                IAsyncOperation<ProtectionPolicyEvaluationResult>** result
        );

        [VtblIndex(10)]
        HRESULT RequestAccessToFilesForAppWithMessageAndBehaviorAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *"
            )]
                IIterable<IntPtr>* sourceItemList,
            HSTRING appPackageFamilyName,
            [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")]
                IProtectionPolicyAuditInfo auditInfo,
            HSTRING messageFromApp,
            [NativeTypeName(
                "ABI::Windows::Security::EnterpriseData::ProtectionPolicyRequestAccessBehavior"
            )]
                ProtectionPolicyRequestAccessBehavior behavior,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **"
            )]
                IAsyncOperation<ProtectionPolicyEvaluationResult>** result
        );

        [VtblIndex(11)]
        HRESULT RequestAccessToFilesForProcessAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *"
            )]
                IIterable<IntPtr>* sourceItemList,
            [NativeTypeName("UINT32")] uint processId,
            [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")]
                IProtectionPolicyAuditInfo auditInfo,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **"
            )]
                IAsyncOperation<ProtectionPolicyEvaluationResult>** result
        );

        [VtblIndex(12)]
        HRESULT RequestAccessToFilesForProcessWithMessageAndBehaviorAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *"
            )]
                IIterable<IntPtr>* sourceItemList,
            [NativeTypeName("UINT32")] uint processId,
            [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *")]
                IProtectionPolicyAuditInfo auditInfo,
            HSTRING messageFromApp,
            [NativeTypeName(
                "ABI::Windows::Security::EnterpriseData::ProtectionPolicyRequestAccessBehavior"
            )]
                ProtectionPolicyRequestAccessBehavior behavior,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **"
            )]
                IAsyncOperation<ProtectionPolicyEvaluationResult>** result
        );

        [VtblIndex(13)]
        HRESULT IsFileProtectionRequiredAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem target,
            HSTRING identity,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** result
        );

        [VtblIndex(14)]
        HRESULT IsFileProtectionRequiredForNewFileAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder parentFolder,
            HSTRING identity,
            HSTRING desiredName,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** result
        );

        [VtblIndex(15)]
        HRESULT get_PrimaryManagedIdentity(HSTRING* value);

        [VtblIndex(16)]
        HRESULT GetPrimaryManagedIdentityForIdentity(HSTRING identity, HSTRING* value);
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
        public delegate* unmanaged<TSelf*, HSTRING, byte*, int> IsRoamableProtectionEnabled;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *, HSTRING, ABI::Windows::Security::EnterpriseData::ProtectionPolicyRequestAccessBehavior, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            IProtectionPolicyAuditInfo,
            HSTRING,
            ProtectionPolicyRequestAccessBehavior,
            IAsyncOperation<ProtectionPolicyEvaluationResult>**,
            int> RequestAccessWithBehaviorAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *, HSTRING, ABI::Windows::Security::EnterpriseData::ProtectionPolicyRequestAccessBehavior, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            IProtectionPolicyAuditInfo,
            HSTRING,
            ProtectionPolicyRequestAccessBehavior,
            IAsyncOperation<ProtectionPolicyEvaluationResult>**,
            int> RequestAccessForAppWithBehaviorAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *, HSTRING, ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<IntPtr>*,
            HSTRING,
            IProtectionPolicyAuditInfo,
            IAsyncOperation<ProtectionPolicyEvaluationResult>**,
            int> RequestAccessToFilesForAppAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *, HSTRING, ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *, HSTRING, ABI::Windows::Security::EnterpriseData::ProtectionPolicyRequestAccessBehavior, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<IntPtr>*,
            HSTRING,
            IProtectionPolicyAuditInfo,
            HSTRING,
            ProtectionPolicyRequestAccessBehavior,
            IAsyncOperation<ProtectionPolicyEvaluationResult>**,
            int> RequestAccessToFilesForAppWithMessageAndBehaviorAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *, UINT32, ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<IntPtr>*,
            uint,
            IProtectionPolicyAuditInfo,
            IAsyncOperation<ProtectionPolicyEvaluationResult>**,
            int> RequestAccessToFilesForProcessAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *, UINT32, ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo *, HSTRING, ABI::Windows::Security::EnterpriseData::ProtectionPolicyRequestAccessBehavior, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<IntPtr>*,
            uint,
            IProtectionPolicyAuditInfo,
            HSTRING,
            ProtectionPolicyRequestAccessBehavior,
            IAsyncOperation<ProtectionPolicyEvaluationResult>**,
            int> RequestAccessToFilesForProcessWithMessageAndBehaviorAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageItem *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageItem,
            HSTRING,
            IAsyncOperation<byte>**,
            int> IsFileProtectionRequiredAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFolder *, HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFolder,
            HSTRING,
            HSTRING,
            IAsyncOperation<byte>**,
            int> IsFileProtectionRequiredForNewFileAsync;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_PrimaryManagedIdentity;

        [NativeTypeName("HRESULT (HSTRING, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING*,
            int> GetPrimaryManagedIdentityForIdentity;
    }

    /// <summary>Initializes a new instance of the <see cref = "IProtectionPolicyManagerStatics4"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IProtectionPolicyManagerStatics4(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IProtectionPolicyManagerStatics4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IProtectionPolicyManagerStatics4(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IProtectionPolicyManagerStatics4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProtectionPolicyManagerStatics4"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IProtectionPolicyManagerStatics4"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IProtectionPolicyManagerStatics4 value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IProtectionPolicyManagerStatics4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IProtectionPolicyManagerStatics4(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IProtectionPolicyManagerStatics4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProtectionPolicyManagerStatics4"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IProtectionPolicyManagerStatics4"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IProtectionPolicyManagerStatics4 value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
