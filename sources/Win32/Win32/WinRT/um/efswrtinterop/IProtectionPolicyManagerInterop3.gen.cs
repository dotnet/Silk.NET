// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/efswrtinterop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("C1C03933-B398-4D93-B0FD-2972ADF802C2")]
[NativeTypeName("struct IProtectionPolicyManagerInterop3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IProtectionPolicyManagerInterop3
    : IProtectionPolicyManagerInterop3.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProtectionPolicyManagerInterop3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerInterop3, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IProtectionPolicyManagerInterop3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IProtectionPolicyManagerInterop3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerInterop3, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerInterop3, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IProtectionPolicyManagerInterop3, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestAccessWithBehaviorForWindowAsync(
        HWND appWindow,
        HSTRING sourceIdentity,
        HSTRING targetIdentity,
        IUnknown auditInfoUnk,
        HSTRING messageFromApp,
        [NativeTypeName("UINT32")] uint behavior,
        [NativeTypeName("const IID &")] Guid* riid,
        void** asyncOperation
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyManagerInterop3,
                HWND,
                HSTRING,
                HSTRING,
                IUnknown,
                HSTRING,
                uint,
                Guid*,
                void**,
                int>)((*lpVtbl)[6])
        )(
            this,
            appWindow,
            sourceIdentity,
            targetIdentity,
            auditInfoUnk,
            messageFromApp,
            behavior,
            riid,
            asyncOperation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RequestAccessForAppWithBehaviorForWindowAsync(
        HWND appWindow,
        HSTRING sourceIdentity,
        HSTRING appPackageFamilyName,
        IUnknown auditInfoUnk,
        HSTRING messageFromApp,
        [NativeTypeName("UINT32")] uint behavior,
        [NativeTypeName("const IID &")] Guid* riid,
        void** asyncOperation
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyManagerInterop3,
                HWND,
                HSTRING,
                HSTRING,
                IUnknown,
                HSTRING,
                uint,
                Guid*,
                void**,
                int>)((*lpVtbl)[7])
        )(
            this,
            appWindow,
            sourceIdentity,
            appPackageFamilyName,
            auditInfoUnk,
            messageFromApp,
            behavior,
            riid,
            asyncOperation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RequestAccessToFilesForAppForWindowAsync(
        HWND appWindow,
        IUnknown sourceItemListUnk,
        HSTRING appPackageFamilyName,
        IUnknown auditInfoUnk,
        [NativeTypeName("const IID &")] Guid* riid,
        void** asyncOperation
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyManagerInterop3,
                HWND,
                IUnknown,
                HSTRING,
                IUnknown,
                Guid*,
                void**,
                int>)((*lpVtbl)[8])
        )(
            this,
            appWindow,
            sourceItemListUnk,
            appPackageFamilyName,
            auditInfoUnk,
            riid,
            asyncOperation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RequestAccessToFilesForAppWithMessageAndBehaviorForWindowAsync(
        HWND appWindow,
        IUnknown sourceItemListUnk,
        HSTRING appPackageFamilyName,
        IUnknown auditInfoUnk,
        HSTRING messageFromApp,
        [NativeTypeName("UINT32")] uint behavior,
        [NativeTypeName("const IID &")] Guid* riid,
        void** asyncOperation
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyManagerInterop3,
                HWND,
                IUnknown,
                HSTRING,
                IUnknown,
                HSTRING,
                uint,
                Guid*,
                void**,
                int>)((*lpVtbl)[9])
        )(
            this,
            appWindow,
            sourceItemListUnk,
            appPackageFamilyName,
            auditInfoUnk,
            messageFromApp,
            behavior,
            riid,
            asyncOperation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RequestAccessToFilesForProcessForWindowAsync(
        HWND appWindow,
        IUnknown sourceItemListUnk,
        [NativeTypeName("UINT32")] uint processId,
        IUnknown auditInfoUnk,
        [NativeTypeName("const IID &")] Guid* riid,
        void** asyncOperation
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyManagerInterop3,
                HWND,
                IUnknown,
                uint,
                IUnknown,
                Guid*,
                void**,
                int>)((*lpVtbl)[10])
        )(this, appWindow, sourceItemListUnk, processId, auditInfoUnk, riid, asyncOperation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RequestAccessToFilesForProcessWithMessageAndBehaviorForWindowAsync(
        HWND appWindow,
        IUnknown sourceItemListUnk,
        [NativeTypeName("UINT32")] uint processId,
        IUnknown auditInfoUnk,
        HSTRING messageFromApp,
        [NativeTypeName("UINT32")] uint behavior,
        [NativeTypeName("const IID &")] Guid* riid,
        void** asyncOperation
    )
    {
        return (
            (delegate* unmanaged<
                IProtectionPolicyManagerInterop3,
                HWND,
                IUnknown,
                uint,
                IUnknown,
                HSTRING,
                uint,
                Guid*,
                void**,
                int>)((*lpVtbl)[11])
        )(
            this,
            appWindow,
            sourceItemListUnk,
            processId,
            auditInfoUnk,
            messageFromApp,
            behavior,
            riid,
            asyncOperation
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestAccessWithBehaviorForWindowAsync(
            HWND appWindow,
            HSTRING sourceIdentity,
            HSTRING targetIdentity,
            IUnknown auditInfoUnk,
            HSTRING messageFromApp,
            [NativeTypeName("UINT32")] uint behavior,
            [NativeTypeName("const IID &")] Guid* riid,
            void** asyncOperation
        );

        [VtblIndex(7)]
        HRESULT RequestAccessForAppWithBehaviorForWindowAsync(
            HWND appWindow,
            HSTRING sourceIdentity,
            HSTRING appPackageFamilyName,
            IUnknown auditInfoUnk,
            HSTRING messageFromApp,
            [NativeTypeName("UINT32")] uint behavior,
            [NativeTypeName("const IID &")] Guid* riid,
            void** asyncOperation
        );

        [VtblIndex(8)]
        HRESULT RequestAccessToFilesForAppForWindowAsync(
            HWND appWindow,
            IUnknown sourceItemListUnk,
            HSTRING appPackageFamilyName,
            IUnknown auditInfoUnk,
            [NativeTypeName("const IID &")] Guid* riid,
            void** asyncOperation
        );

        [VtblIndex(9)]
        HRESULT RequestAccessToFilesForAppWithMessageAndBehaviorForWindowAsync(
            HWND appWindow,
            IUnknown sourceItemListUnk,
            HSTRING appPackageFamilyName,
            IUnknown auditInfoUnk,
            HSTRING messageFromApp,
            [NativeTypeName("UINT32")] uint behavior,
            [NativeTypeName("const IID &")] Guid* riid,
            void** asyncOperation
        );

        [VtblIndex(10)]
        HRESULT RequestAccessToFilesForProcessForWindowAsync(
            HWND appWindow,
            IUnknown sourceItemListUnk,
            [NativeTypeName("UINT32")] uint processId,
            IUnknown auditInfoUnk,
            [NativeTypeName("const IID &")] Guid* riid,
            void** asyncOperation
        );

        [VtblIndex(11)]
        HRESULT RequestAccessToFilesForProcessWithMessageAndBehaviorForWindowAsync(
            HWND appWindow,
            IUnknown sourceItemListUnk,
            [NativeTypeName("UINT32")] uint processId,
            IUnknown auditInfoUnk,
            HSTRING messageFromApp,
            [NativeTypeName("UINT32")] uint behavior,
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
            "HRESULT (HWND, HSTRING, HSTRING, IUnknown *, HSTRING, UINT32, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HWND,
            HSTRING,
            HSTRING,
            IUnknown,
            HSTRING,
            uint,
            Guid*,
            void**,
            int> RequestAccessWithBehaviorForWindowAsync;

        [NativeTypeName(
            "HRESULT (HWND, HSTRING, HSTRING, IUnknown *, HSTRING, UINT32, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HWND,
            HSTRING,
            HSTRING,
            IUnknown,
            HSTRING,
            uint,
            Guid*,
            void**,
            int> RequestAccessForAppWithBehaviorForWindowAsync;

        [NativeTypeName(
            "HRESULT (HWND, IUnknown *, HSTRING, IUnknown *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HWND,
            IUnknown,
            HSTRING,
            IUnknown,
            Guid*,
            void**,
            int> RequestAccessToFilesForAppForWindowAsync;

        [NativeTypeName(
            "HRESULT (HWND, IUnknown *, HSTRING, IUnknown *, HSTRING, UINT32, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HWND,
            IUnknown,
            HSTRING,
            IUnknown,
            HSTRING,
            uint,
            Guid*,
            void**,
            int> RequestAccessToFilesForAppWithMessageAndBehaviorForWindowAsync;

        [NativeTypeName(
            "HRESULT (HWND, IUnknown *, UINT32, IUnknown *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HWND,
            IUnknown,
            uint,
            IUnknown,
            Guid*,
            void**,
            int> RequestAccessToFilesForProcessForWindowAsync;

        [NativeTypeName(
            "HRESULT (HWND, IUnknown *, UINT32, IUnknown *, HSTRING, UINT32, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HWND,
            IUnknown,
            uint,
            IUnknown,
            HSTRING,
            uint,
            Guid*,
            void**,
            int> RequestAccessToFilesForProcessWithMessageAndBehaviorForWindowAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IProtectionPolicyManagerInterop3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IProtectionPolicyManagerInterop3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IProtectionPolicyManagerInterop3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IProtectionPolicyManagerInterop3(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IProtectionPolicyManagerInterop3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProtectionPolicyManagerInterop3"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IProtectionPolicyManagerInterop3"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IProtectionPolicyManagerInterop3 value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IProtectionPolicyManagerInterop3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IProtectionPolicyManagerInterop3(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IProtectionPolicyManagerInterop3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProtectionPolicyManagerInterop3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IProtectionPolicyManagerInterop3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IProtectionPolicyManagerInterop3 value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
