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

[Guid("7ED4180B-92E8-42D5-83D4-25440B423549")]
[NativeTypeName("struct IProtectionPolicyAuditInfoFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProtectionPolicyAuditInfoFactory
    : IProtectionPolicyAuditInfoFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProtectionPolicyAuditInfoFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IProtectionPolicyAuditInfoFactory, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IProtectionPolicyAuditInfoFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IProtectionPolicyAuditInfoFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IProtectionPolicyAuditInfoFactory, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IProtectionPolicyAuditInfoFactory, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IProtectionPolicyAuditInfoFactory, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create(
        [NativeTypeName("ABI::Windows::Security::EnterpriseData::ProtectionPolicyAuditAction")]
            ProtectionPolicyAuditAction action,
        HSTRING dataDescription,
        HSTRING sourceDescription,
        HSTRING targetDescription,
        [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo **")]
            IProtectionPolicyAuditInfo* result
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyAuditInfoFactory,
                ProtectionPolicyAuditAction,
                HSTRING,
                HSTRING,
                HSTRING,
                IProtectionPolicyAuditInfo*,
                int>)((*lpVtbl)[6])
        )(this, action, dataDescription, sourceDescription, targetDescription, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithActionAndDataDescription(
        [NativeTypeName("ABI::Windows::Security::EnterpriseData::ProtectionPolicyAuditAction")]
            ProtectionPolicyAuditAction action,
        HSTRING dataDescription,
        [NativeTypeName("ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo **")]
            IProtectionPolicyAuditInfo* result
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyAuditInfoFactory,
                ProtectionPolicyAuditAction,
                HSTRING,
                IProtectionPolicyAuditInfo*,
                int>)((*lpVtbl)[7])
        )(this, action, dataDescription, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create(
            [NativeTypeName("ABI::Windows::Security::EnterpriseData::ProtectionPolicyAuditAction")]
                ProtectionPolicyAuditAction action,
            HSTRING dataDescription,
            HSTRING sourceDescription,
            HSTRING targetDescription,
            [NativeTypeName(
                "ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo **"
            )]
                IProtectionPolicyAuditInfo* result
        );

        [VtblIndex(7)]
        HRESULT CreateWithActionAndDataDescription(
            [NativeTypeName("ABI::Windows::Security::EnterpriseData::ProtectionPolicyAuditAction")]
                ProtectionPolicyAuditAction action,
            HSTRING dataDescription,
            [NativeTypeName(
                "ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo **"
            )]
                IProtectionPolicyAuditInfo* result
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
            "HRESULT (ABI::Windows::Security::EnterpriseData::ProtectionPolicyAuditAction, HSTRING, HSTRING, HSTRING, ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ProtectionPolicyAuditAction,
            HSTRING,
            HSTRING,
            HSTRING,
            IProtectionPolicyAuditInfo*,
            int> Create;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::EnterpriseData::ProtectionPolicyAuditAction, HSTRING, ABI::Windows::Security::EnterpriseData::IProtectionPolicyAuditInfo **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ProtectionPolicyAuditAction,
            HSTRING,
            IProtectionPolicyAuditInfo*,
            int> CreateWithActionAndDataDescription;
    }

    /// <summary>Initializes a new instance of the <see cref = "IProtectionPolicyAuditInfoFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IProtectionPolicyAuditInfoFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IProtectionPolicyAuditInfoFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IProtectionPolicyAuditInfoFactory(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IProtectionPolicyAuditInfoFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProtectionPolicyAuditInfoFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IProtectionPolicyAuditInfoFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IProtectionPolicyAuditInfoFactory value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IProtectionPolicyAuditInfoFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IProtectionPolicyAuditInfoFactory(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IProtectionPolicyAuditInfoFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProtectionPolicyAuditInfoFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IProtectionPolicyAuditInfoFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IProtectionPolicyAuditInfoFactory value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
