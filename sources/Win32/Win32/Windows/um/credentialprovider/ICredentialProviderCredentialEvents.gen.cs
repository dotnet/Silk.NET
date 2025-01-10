// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("FA6FA76B-66B7-4B11-95F1-86171118E816")]
[NativeTypeName("struct ICredentialProviderCredentialEvents : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICredentialProviderCredentialEvents
    : ICredentialProviderCredentialEvents.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICredentialProviderCredentialEvents));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ICredentialProviderCredentialEvents, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICredentialProviderCredentialEvents, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICredentialProviderCredentialEvents, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetFieldState(
        ICredentialProviderCredential pcpc,
        [NativeTypeName("DWORD")] uint dwFieldID,
        CREDENTIAL_PROVIDER_FIELD_STATE cpfs
    )
    {
        return (
            (delegate* unmanaged<
                ICredentialProviderCredentialEvents,
                ICredentialProviderCredential,
                uint,
                CREDENTIAL_PROVIDER_FIELD_STATE,
                int>)((*lpVtbl)[3])
        )(this, pcpc, dwFieldID, cpfs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetFieldInteractiveState(
        ICredentialProviderCredential pcpc,
        [NativeTypeName("DWORD")] uint dwFieldID,
        CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE cpfis
    )
    {
        return (
            (delegate* unmanaged<
                ICredentialProviderCredentialEvents,
                ICredentialProviderCredential,
                uint,
                CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE,
                int>)((*lpVtbl)[4])
        )(this, pcpc, dwFieldID, cpfis);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetFieldString(
        ICredentialProviderCredential pcpc,
        [NativeTypeName("DWORD")] uint dwFieldID,
        [NativeTypeName("LPCWSTR")] ushort* psz
    )
    {
        return (
            (delegate* unmanaged<
                ICredentialProviderCredentialEvents,
                ICredentialProviderCredential,
                uint,
                ushort*,
                int>)((*lpVtbl)[5])
        )(this, pcpc, dwFieldID, psz);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetFieldCheckbox(
        ICredentialProviderCredential pcpc,
        [NativeTypeName("DWORD")] uint dwFieldID,
        BOOL bChecked,
        [NativeTypeName("LPCWSTR")] ushort* pszLabel
    )
    {
        return (
            (delegate* unmanaged<
                ICredentialProviderCredentialEvents,
                ICredentialProviderCredential,
                uint,
                BOOL,
                ushort*,
                int>)((*lpVtbl)[6])
        )(this, pcpc, dwFieldID, bChecked, pszLabel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetFieldBitmap(
        ICredentialProviderCredential pcpc,
        [NativeTypeName("DWORD")] uint dwFieldID,
        HBITMAP hbmp
    )
    {
        return (
            (delegate* unmanaged<
                ICredentialProviderCredentialEvents,
                ICredentialProviderCredential,
                uint,
                HBITMAP,
                int>)((*lpVtbl)[7])
        )(this, pcpc, dwFieldID, hbmp);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetFieldComboBoxSelectedItem(
        ICredentialProviderCredential pcpc,
        [NativeTypeName("DWORD")] uint dwFieldID,
        [NativeTypeName("DWORD")] uint dwSelectedItem
    )
    {
        return (
            (delegate* unmanaged<
                ICredentialProviderCredentialEvents,
                ICredentialProviderCredential,
                uint,
                uint,
                int>)((*lpVtbl)[8])
        )(this, pcpc, dwFieldID, dwSelectedItem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT DeleteFieldComboBoxItem(
        ICredentialProviderCredential pcpc,
        [NativeTypeName("DWORD")] uint dwFieldID,
        [NativeTypeName("DWORD")] uint dwItem
    )
    {
        return (
            (delegate* unmanaged<
                ICredentialProviderCredentialEvents,
                ICredentialProviderCredential,
                uint,
                uint,
                int>)((*lpVtbl)[9])
        )(this, pcpc, dwFieldID, dwItem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT AppendFieldComboBoxItem(
        ICredentialProviderCredential pcpc,
        [NativeTypeName("DWORD")] uint dwFieldID,
        [NativeTypeName("LPCWSTR")] ushort* pszItem
    )
    {
        return (
            (delegate* unmanaged<
                ICredentialProviderCredentialEvents,
                ICredentialProviderCredential,
                uint,
                ushort*,
                int>)((*lpVtbl)[10])
        )(this, pcpc, dwFieldID, pszItem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetFieldSubmitButton(
        ICredentialProviderCredential pcpc,
        [NativeTypeName("DWORD")] uint dwFieldID,
        [NativeTypeName("DWORD")] uint dwAdjacentTo
    )
    {
        return (
            (delegate* unmanaged<
                ICredentialProviderCredentialEvents,
                ICredentialProviderCredential,
                uint,
                uint,
                int>)((*lpVtbl)[11])
        )(this, pcpc, dwFieldID, dwAdjacentTo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT OnCreatingWindow(HWND* phwndOwner)
    {
        return (
            (delegate* unmanaged<ICredentialProviderCredentialEvents, HWND*, int>)((*lpVtbl)[12])
        )(this, phwndOwner);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetFieldState(
            ICredentialProviderCredential pcpc,
            [NativeTypeName("DWORD")] uint dwFieldID,
            CREDENTIAL_PROVIDER_FIELD_STATE cpfs
        );

        [VtblIndex(4)]
        HRESULT SetFieldInteractiveState(
            ICredentialProviderCredential pcpc,
            [NativeTypeName("DWORD")] uint dwFieldID,
            CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE cpfis
        );

        [VtblIndex(5)]
        HRESULT SetFieldString(
            ICredentialProviderCredential pcpc,
            [NativeTypeName("DWORD")] uint dwFieldID,
            [NativeTypeName("LPCWSTR")] ushort* psz
        );

        [VtblIndex(6)]
        HRESULT SetFieldCheckbox(
            ICredentialProviderCredential pcpc,
            [NativeTypeName("DWORD")] uint dwFieldID,
            BOOL bChecked,
            [NativeTypeName("LPCWSTR")] ushort* pszLabel
        );

        [VtblIndex(7)]
        HRESULT SetFieldBitmap(
            ICredentialProviderCredential pcpc,
            [NativeTypeName("DWORD")] uint dwFieldID,
            HBITMAP hbmp
        );

        [VtblIndex(8)]
        HRESULT SetFieldComboBoxSelectedItem(
            ICredentialProviderCredential pcpc,
            [NativeTypeName("DWORD")] uint dwFieldID,
            [NativeTypeName("DWORD")] uint dwSelectedItem
        );

        [VtblIndex(9)]
        HRESULT DeleteFieldComboBoxItem(
            ICredentialProviderCredential pcpc,
            [NativeTypeName("DWORD")] uint dwFieldID,
            [NativeTypeName("DWORD")] uint dwItem
        );

        [VtblIndex(10)]
        HRESULT AppendFieldComboBoxItem(
            ICredentialProviderCredential pcpc,
            [NativeTypeName("DWORD")] uint dwFieldID,
            [NativeTypeName("LPCWSTR")] ushort* pszItem
        );

        [VtblIndex(11)]
        HRESULT SetFieldSubmitButton(
            ICredentialProviderCredential pcpc,
            [NativeTypeName("DWORD")] uint dwFieldID,
            [NativeTypeName("DWORD")] uint dwAdjacentTo
        );

        [VtblIndex(12)]
        HRESULT OnCreatingWindow(HWND* phwndOwner);
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

        [NativeTypeName(
            "HRESULT (ICredentialProviderCredential *, DWORD, CREDENTIAL_PROVIDER_FIELD_STATE) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICredentialProviderCredential,
            uint,
            CREDENTIAL_PROVIDER_FIELD_STATE,
            int> SetFieldState;

        [NativeTypeName(
            "HRESULT (ICredentialProviderCredential *, DWORD, CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICredentialProviderCredential,
            uint,
            CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE,
            int> SetFieldInteractiveState;

        [NativeTypeName(
            "HRESULT (ICredentialProviderCredential *, DWORD, LPCWSTR) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICredentialProviderCredential,
            uint,
            ushort*,
            int> SetFieldString;

        [NativeTypeName(
            "HRESULT (ICredentialProviderCredential *, DWORD, BOOL, LPCWSTR) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICredentialProviderCredential,
            uint,
            BOOL,
            ushort*,
            int> SetFieldCheckbox;

        [NativeTypeName(
            "HRESULT (ICredentialProviderCredential *, DWORD, HBITMAP) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICredentialProviderCredential,
            uint,
            HBITMAP,
            int> SetFieldBitmap;

        [NativeTypeName(
            "HRESULT (ICredentialProviderCredential *, DWORD, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICredentialProviderCredential,
            uint,
            uint,
            int> SetFieldComboBoxSelectedItem;

        [NativeTypeName(
            "HRESULT (ICredentialProviderCredential *, DWORD, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICredentialProviderCredential,
            uint,
            uint,
            int> DeleteFieldComboBoxItem;

        [NativeTypeName(
            "HRESULT (ICredentialProviderCredential *, DWORD, LPCWSTR) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICredentialProviderCredential,
            uint,
            ushort*,
            int> AppendFieldComboBoxItem;

        [NativeTypeName(
            "HRESULT (ICredentialProviderCredential *, DWORD, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICredentialProviderCredential,
            uint,
            uint,
            int> SetFieldSubmitButton;

        [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND*, int> OnCreatingWindow;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICredentialProviderCredentialEvents"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICredentialProviderCredentialEvents(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICredentialProviderCredentialEvents"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICredentialProviderCredentialEvents(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ICredentialProviderCredentialEvents(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICredentialProviderCredentialEvents"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICredentialProviderCredentialEvents"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ICredentialProviderCredentialEvents value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
