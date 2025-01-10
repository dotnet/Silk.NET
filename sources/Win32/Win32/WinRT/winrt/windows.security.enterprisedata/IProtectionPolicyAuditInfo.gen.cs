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

[Guid("425AB7E4-FEB7-44FC-B3BB-C3C4D7ECBEBB")]
[NativeTypeName("struct IProtectionPolicyAuditInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProtectionPolicyAuditInfo
    : IProtectionPolicyAuditInfo.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProtectionPolicyAuditInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IProtectionPolicyAuditInfo, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IProtectionPolicyAuditInfo, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IProtectionPolicyAuditInfo, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IProtectionPolicyAuditInfo, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IProtectionPolicyAuditInfo, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IProtectionPolicyAuditInfo, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_Action(
        [NativeTypeName("ABI::Windows::Security::EnterpriseData::ProtectionPolicyAuditAction")]
            ProtectionPolicyAuditAction value
    )
    {
        return (
            (delegate* unmanaged<IProtectionPolicyAuditInfo, ProtectionPolicyAuditAction, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Action(
        [NativeTypeName("ABI::Windows::Security::EnterpriseData::ProtectionPolicyAuditAction *")]
            ProtectionPolicyAuditAction* value
    )
    {
        return (
            (delegate* unmanaged<IProtectionPolicyAuditInfo, ProtectionPolicyAuditAction*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_DataDescription(HSTRING value)
    {
        return ((delegate* unmanaged<IProtectionPolicyAuditInfo, HSTRING, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_DataDescription(HSTRING* value)
    {
        return ((delegate* unmanaged<IProtectionPolicyAuditInfo, HSTRING*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_SourceDescription(HSTRING value)
    {
        return ((delegate* unmanaged<IProtectionPolicyAuditInfo, HSTRING, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_SourceDescription(HSTRING* value)
    {
        return ((delegate* unmanaged<IProtectionPolicyAuditInfo, HSTRING*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_TargetDescription(HSTRING value)
    {
        return ((delegate* unmanaged<IProtectionPolicyAuditInfo, HSTRING, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_TargetDescription(HSTRING* value)
    {
        return ((delegate* unmanaged<IProtectionPolicyAuditInfo, HSTRING*, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_Action(
            [NativeTypeName("ABI::Windows::Security::EnterpriseData::ProtectionPolicyAuditAction")]
                ProtectionPolicyAuditAction value
        );

        [VtblIndex(7)]
        HRESULT get_Action(
            [NativeTypeName(
                "ABI::Windows::Security::EnterpriseData::ProtectionPolicyAuditAction *"
            )]
                ProtectionPolicyAuditAction* value
        );

        [VtblIndex(8)]
        HRESULT put_DataDescription(HSTRING value);

        [VtblIndex(9)]
        HRESULT get_DataDescription(HSTRING* value);

        [VtblIndex(10)]
        HRESULT put_SourceDescription(HSTRING value);

        [VtblIndex(11)]
        HRESULT get_SourceDescription(HSTRING* value);

        [VtblIndex(12)]
        HRESULT put_TargetDescription(HSTRING value);

        [VtblIndex(13)]
        HRESULT get_TargetDescription(HSTRING* value);
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
            "HRESULT (ABI::Windows::Security::EnterpriseData::ProtectionPolicyAuditAction) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ProtectionPolicyAuditAction, int> put_Action;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::EnterpriseData::ProtectionPolicyAuditAction *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ProtectionPolicyAuditAction*, int> get_Action;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_DataDescription;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DataDescription;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_SourceDescription;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_SourceDescription;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_TargetDescription;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_TargetDescription;
    }

    /// <summary>Initializes a new instance of the <see cref = "IProtectionPolicyAuditInfo"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IProtectionPolicyAuditInfo(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IProtectionPolicyAuditInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IProtectionPolicyAuditInfo(Silk.NET.WinRT.IInspectable value)
    {
        return new IProtectionPolicyAuditInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProtectionPolicyAuditInfo"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IProtectionPolicyAuditInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IProtectionPolicyAuditInfo value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IProtectionPolicyAuditInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IProtectionPolicyAuditInfo(Silk.NET.Windows.IUnknown value)
    {
        return new IProtectionPolicyAuditInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProtectionPolicyAuditInfo"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IProtectionPolicyAuditInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IProtectionPolicyAuditInfo value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
