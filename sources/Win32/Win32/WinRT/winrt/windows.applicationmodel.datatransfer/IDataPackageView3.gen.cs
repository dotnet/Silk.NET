// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.datatransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("D37771A8-DDAD-4288-8428-D1CAE394128B")]
[NativeTypeName("struct IDataPackageView3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDataPackageView3 : IDataPackageView3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDataPackageView3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDataPackageView3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDataPackageView3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDataPackageView3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IDataPackageView3, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IDataPackageView3, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IDataPackageView3, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestAccessAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **"
        )]
            IAsyncOperation<ProtectionPolicyEvaluationResult>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IDataPackageView3,
                IAsyncOperation<ProtectionPolicyEvaluationResult>**,
                int>)((*lpVtbl)[6])
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RequestAccessWithEnterpriseIdAsync(
        HSTRING enterpriseId,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **"
        )]
            IAsyncOperation<ProtectionPolicyEvaluationResult>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IDataPackageView3,
                HSTRING,
                IAsyncOperation<ProtectionPolicyEvaluationResult>**,
                int>)((*lpVtbl)[7])
        )(this, enterpriseId, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT UnlockAndAssumeEnterpriseIdentity(
        [NativeTypeName(
            "ABI::Windows::Security::EnterpriseData::ProtectionPolicyEvaluationResult *"
        )]
            ProtectionPolicyEvaluationResult* result
    )
    {
        return (
            (delegate* unmanaged<IDataPackageView3, ProtectionPolicyEvaluationResult*, int>)(
                (*lpVtbl)[8]
            )
        )(this, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestAccessAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **"
            )]
                IAsyncOperation<ProtectionPolicyEvaluationResult>** operation
        );

        [VtblIndex(7)]
        HRESULT RequestAccessWithEnterpriseIdAsync(
            HSTRING enterpriseId,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **"
            )]
                IAsyncOperation<ProtectionPolicyEvaluationResult>** operation
        );

        [VtblIndex(8)]
        HRESULT UnlockAndAssumeEnterpriseIdentity(
            [NativeTypeName(
                "ABI::Windows::Security::EnterpriseData::ProtectionPolicyEvaluationResult *"
            )]
                ProtectionPolicyEvaluationResult* result
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
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<ProtectionPolicyEvaluationResult>**,
            int> RequestAccessAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectionPolicyEvaluationResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<ProtectionPolicyEvaluationResult>**,
            int> RequestAccessWithEnterpriseIdAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::EnterpriseData::ProtectionPolicyEvaluationResult *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ProtectionPolicyEvaluationResult*,
            int> UnlockAndAssumeEnterpriseIdentity;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDataPackageView3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDataPackageView3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDataPackageView3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDataPackageView3(Silk.NET.WinRT.IInspectable value)
    {
        return new IDataPackageView3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDataPackageView3"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDataPackageView3"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IDataPackageView3 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDataPackageView3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDataPackageView3(Silk.NET.Windows.IUnknown value)
    {
        return new IDataPackageView3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDataPackageView3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDataPackageView3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDataPackageView3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
