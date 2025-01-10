// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/efswrtinterop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("157CFBE4-A78D-4156-B384-61FDAC41E686")]
[NativeTypeName("struct IProtectionPolicyManagerInterop2 : IInspectable")]
[NativeInheritance("IInspectable")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IProtectionPolicyManagerInterop2
    : IProtectionPolicyManagerInterop2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProtectionPolicyManagerInterop2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerInterop2, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IProtectionPolicyManagerInterop2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IProtectionPolicyManagerInterop2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerInterop2, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerInterop2, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerInterop2, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestAccessForAppWithWindowAsync(
        HWND appWindow,
        HSTRING sourceIdentity,
        HSTRING appPackageFamilyName,
        [NativeTypeName("const IID &")] Guid* riid,
        void** asyncOperation
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyManagerInterop2,
                HWND,
                HSTRING,
                HSTRING,
                Guid*,
                void**,
                int>)((*lpVtbl)[6])
        )(this, appWindow, sourceIdentity, appPackageFamilyName, riid, asyncOperation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RequestAccessWithAuditingInfoForWindowAsync(
        HWND appWindow,
        HSTRING sourceIdentity,
        HSTRING targetIdentity,
        IUnknown auditInfoUnk,
        [NativeTypeName("const IID &")] Guid* riid,
        void** asyncOperation
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyManagerInterop2,
                HWND,
                HSTRING,
                HSTRING,
                IUnknown,
                Guid*,
                void**,
                int>)((*lpVtbl)[7])
        )(this, appWindow, sourceIdentity, targetIdentity, auditInfoUnk, riid, asyncOperation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RequestAccessWithMessageForWindowAsync(
        HWND appWindow,
        HSTRING sourceIdentity,
        HSTRING targetIdentity,
        IUnknown auditInfoUnk,
        HSTRING messageFromApp,
        [NativeTypeName("const IID &")] Guid* riid,
        void** asyncOperation
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyManagerInterop2,
                HWND,
                HSTRING,
                HSTRING,
                IUnknown,
                HSTRING,
                Guid*,
                void**,
                int>)((*lpVtbl)[8])
        )(
            this,
            appWindow,
            sourceIdentity,
            targetIdentity,
            auditInfoUnk,
            messageFromApp,
            riid,
            asyncOperation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RequestAccessForAppWithAuditingInfoForWindowAsync(
        HWND appWindow,
        HSTRING sourceIdentity,
        HSTRING appPackageFamilyName,
        IUnknown auditInfoUnk,
        [NativeTypeName("const IID &")] Guid* riid,
        void** asyncOperation
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyManagerInterop2,
                HWND,
                HSTRING,
                HSTRING,
                IUnknown,
                Guid*,
                void**,
                int>)((*lpVtbl)[9])
        )(
            this,
            appWindow,
            sourceIdentity,
            appPackageFamilyName,
            auditInfoUnk,
            riid,
            asyncOperation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RequestAccessForAppWithMessageForWindowAsync(
        HWND appWindow,
        HSTRING sourceIdentity,
        HSTRING appPackageFamilyName,
        IUnknown auditInfoUnk,
        HSTRING messageFromApp,
        [NativeTypeName("const IID &")] Guid* riid,
        void** asyncOperation
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyManagerInterop2,
                HWND,
                HSTRING,
                HSTRING,
                IUnknown,
                HSTRING,
                Guid*,
                void**,
                int>)((*lpVtbl)[10])
        )(
            this,
            appWindow,
            sourceIdentity,
            appPackageFamilyName,
            auditInfoUnk,
            messageFromApp,
            riid,
            asyncOperation
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestAccessForAppWithWindowAsync(
            HWND appWindow,
            HSTRING sourceIdentity,
            HSTRING appPackageFamilyName,
            [NativeTypeName("const IID &")] Guid* riid,
            void** asyncOperation
        );

        [VtblIndex(7)]
        HRESULT RequestAccessWithAuditingInfoForWindowAsync(
            HWND appWindow,
            HSTRING sourceIdentity,
            HSTRING targetIdentity,
            IUnknown auditInfoUnk,
            [NativeTypeName("const IID &")] Guid* riid,
            void** asyncOperation
        );

        [VtblIndex(8)]
        HRESULT RequestAccessWithMessageForWindowAsync(
            HWND appWindow,
            HSTRING sourceIdentity,
            HSTRING targetIdentity,
            IUnknown auditInfoUnk,
            HSTRING messageFromApp,
            [NativeTypeName("const IID &")] Guid* riid,
            void** asyncOperation
        );

        [VtblIndex(9)]
        HRESULT RequestAccessForAppWithAuditingInfoForWindowAsync(
            HWND appWindow,
            HSTRING sourceIdentity,
            HSTRING appPackageFamilyName,
            IUnknown auditInfoUnk,
            [NativeTypeName("const IID &")] Guid* riid,
            void** asyncOperation
        );

        [VtblIndex(10)]
        HRESULT RequestAccessForAppWithMessageForWindowAsync(
            HWND appWindow,
            HSTRING sourceIdentity,
            HSTRING appPackageFamilyName,
            IUnknown auditInfoUnk,
            HSTRING messageFromApp,
            [NativeTypeName("const IID &")] Guid* riid,
            void** asyncOperation
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
            "HRESULT (HWND, HSTRING, HSTRING, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HWND,
            HSTRING,
            HSTRING,
            Guid*,
            void**,
            int> RequestAccessForAppWithWindowAsync;

        [NativeTypeName(
            "HRESULT (HWND, HSTRING, HSTRING, IUnknown *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HWND,
            HSTRING,
            HSTRING,
            IUnknown,
            Guid*,
            void**,
            int> RequestAccessWithAuditingInfoForWindowAsync;

        [NativeTypeName(
            "HRESULT (HWND, HSTRING, HSTRING, IUnknown *, HSTRING, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HWND,
            HSTRING,
            HSTRING,
            IUnknown,
            HSTRING,
            Guid*,
            void**,
            int> RequestAccessWithMessageForWindowAsync;

        [NativeTypeName(
            "HRESULT (HWND, HSTRING, HSTRING, IUnknown *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HWND,
            HSTRING,
            HSTRING,
            IUnknown,
            Guid*,
            void**,
            int> RequestAccessForAppWithAuditingInfoForWindowAsync;

        [NativeTypeName(
            "HRESULT (HWND, HSTRING, HSTRING, IUnknown *, HSTRING, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HWND,
            HSTRING,
            HSTRING,
            IUnknown,
            HSTRING,
            Guid*,
            void**,
            int> RequestAccessForAppWithMessageForWindowAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IProtectionPolicyManagerInterop2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IProtectionPolicyManagerInterop2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IProtectionPolicyManagerInterop2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IProtectionPolicyManagerInterop2(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IProtectionPolicyManagerInterop2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProtectionPolicyManagerInterop2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IProtectionPolicyManagerInterop2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IProtectionPolicyManagerInterop2 value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IProtectionPolicyManagerInterop2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IProtectionPolicyManagerInterop2(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IProtectionPolicyManagerInterop2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProtectionPolicyManagerInterop2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IProtectionPolicyManagerInterop2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IProtectionPolicyManagerInterop2 value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
