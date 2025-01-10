// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("63913A93-40C1-481A-818D-4072FF8C70CC")]
[NativeTypeName("struct ICredentialProviderCredential : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICredentialProviderCredential
    : ICredentialProviderCredential.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICredentialProviderCredential));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ICredentialProviderCredential, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICredentialProviderCredential, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICredentialProviderCredential, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Advise(ICredentialProviderCredentialEvents pcpce)
    {
        return (
            (delegate* unmanaged<
                ICredentialProviderCredential,
                ICredentialProviderCredentialEvents,
                int>)((*lpVtbl)[3])
        )(this, pcpce);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnAdvise()
    {
        return ((delegate* unmanaged<ICredentialProviderCredential, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetSelected(BOOL* pbAutoLogon)
    {
        return ((delegate* unmanaged<ICredentialProviderCredential, BOOL*, int>)((*lpVtbl)[5]))(
            this,
            pbAutoLogon
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetDeselected()
    {
        return ((delegate* unmanaged<ICredentialProviderCredential, int>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFieldState(
        [NativeTypeName("DWORD")] uint dwFieldID,
        CREDENTIAL_PROVIDER_FIELD_STATE* pcpfs,
        CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE* pcpfis
    )
    {
        return (
            (delegate* unmanaged<
                ICredentialProviderCredential,
                uint,
                CREDENTIAL_PROVIDER_FIELD_STATE*,
                CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE*,
                int>)((*lpVtbl)[7])
        )(this, dwFieldID, pcpfs, pcpfis);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetStringValue(
        [NativeTypeName("DWORD")] uint dwFieldID,
        [NativeTypeName("LPWSTR *")] ushort** ppsz
    )
    {
        return (
            (delegate* unmanaged<ICredentialProviderCredential, uint, ushort**, int>)((*lpVtbl)[8])
        )(this, dwFieldID, ppsz);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetBitmapValue([NativeTypeName("DWORD")] uint dwFieldID, HBITMAP* phbmp)
    {
        return (
            (delegate* unmanaged<ICredentialProviderCredential, uint, HBITMAP*, int>)((*lpVtbl)[9])
        )(this, dwFieldID, phbmp);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetCheckboxValue(
        [NativeTypeName("DWORD")] uint dwFieldID,
        BOOL* pbChecked,
        [NativeTypeName("LPWSTR *")] ushort** ppszLabel
    )
    {
        return (
            (delegate* unmanaged<ICredentialProviderCredential, uint, BOOL*, ushort**, int>)(
                (*lpVtbl)[10]
            )
        )(this, dwFieldID, pbChecked, ppszLabel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetSubmitButtonValue(
        [NativeTypeName("DWORD")] uint dwFieldID,
        [NativeTypeName("DWORD *")] uint* pdwAdjacentTo
    )
    {
        return (
            (delegate* unmanaged<ICredentialProviderCredential, uint, uint*, int>)((*lpVtbl)[11])
        )(this, dwFieldID, pdwAdjacentTo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetComboBoxValueCount(
        [NativeTypeName("DWORD")] uint dwFieldID,
        [NativeTypeName("DWORD *")] uint* pcItems,
        [NativeTypeName("DWORD *")] uint* pdwSelectedItem
    )
    {
        return (
            (delegate* unmanaged<ICredentialProviderCredential, uint, uint*, uint*, int>)(
                (*lpVtbl)[12]
            )
        )(this, dwFieldID, pcItems, pdwSelectedItem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetComboBoxValueAt(
        [NativeTypeName("DWORD")] uint dwFieldID,
        [NativeTypeName("DWORD")] uint dwItem,
        [NativeTypeName("LPWSTR *")] ushort** ppszItem
    )
    {
        return (
            (delegate* unmanaged<ICredentialProviderCredential, uint, uint, ushort**, int>)(
                (*lpVtbl)[13]
            )
        )(this, dwFieldID, dwItem, ppszItem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetStringValue(
        [NativeTypeName("DWORD")] uint dwFieldID,
        [NativeTypeName("LPCWSTR")] ushort* psz
    )
    {
        return (
            (delegate* unmanaged<ICredentialProviderCredential, uint, ushort*, int>)((*lpVtbl)[14])
        )(this, dwFieldID, psz);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetCheckboxValue([NativeTypeName("DWORD")] uint dwFieldID, BOOL bChecked)
    {
        return (
            (delegate* unmanaged<ICredentialProviderCredential, uint, BOOL, int>)((*lpVtbl)[15])
        )(this, dwFieldID, bChecked);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetComboBoxSelectedValue(
        [NativeTypeName("DWORD")] uint dwFieldID,
        [NativeTypeName("DWORD")] uint dwSelectedItem
    )
    {
        return (
            (delegate* unmanaged<ICredentialProviderCredential, uint, uint, int>)((*lpVtbl)[16])
        )(this, dwFieldID, dwSelectedItem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CommandLinkClicked([NativeTypeName("DWORD")] uint dwFieldID)
    {
        return ((delegate* unmanaged<ICredentialProviderCredential, uint, int>)((*lpVtbl)[17]))(
            this,
            dwFieldID
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetSerialization(
        CREDENTIAL_PROVIDER_GET_SERIALIZATION_RESPONSE* pcpgsr,
        CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION* pcpcs,
        [NativeTypeName("LPWSTR *")] ushort** ppszOptionalStatusText,
        CREDENTIAL_PROVIDER_STATUS_ICON* pcpsiOptionalStatusIcon
    )
    {
        return (
            (delegate* unmanaged<
                ICredentialProviderCredential,
                CREDENTIAL_PROVIDER_GET_SERIALIZATION_RESPONSE*,
                CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION*,
                ushort**,
                CREDENTIAL_PROVIDER_STATUS_ICON*,
                int>)((*lpVtbl)[18])
        )(this, pcpgsr, pcpcs, ppszOptionalStatusText, pcpsiOptionalStatusIcon);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT ReportResult(
        [NativeTypeName("NTSTATUS")] int ntsStatus,
        [NativeTypeName("NTSTATUS")] int ntsSubstatus,
        [NativeTypeName("LPWSTR *")] ushort** ppszOptionalStatusText,
        CREDENTIAL_PROVIDER_STATUS_ICON* pcpsiOptionalStatusIcon
    )
    {
        return (
            (delegate* unmanaged<
                ICredentialProviderCredential,
                int,
                int,
                ushort**,
                CREDENTIAL_PROVIDER_STATUS_ICON*,
                int>)((*lpVtbl)[19])
        )(this, ntsStatus, ntsSubstatus, ppszOptionalStatusText, pcpsiOptionalStatusIcon);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Advise(ICredentialProviderCredentialEvents pcpce);

        [VtblIndex(4)]
        HRESULT UnAdvise();

        [VtblIndex(5)]
        HRESULT SetSelected(BOOL* pbAutoLogon);

        [VtblIndex(6)]
        HRESULT SetDeselected();

        [VtblIndex(7)]
        HRESULT GetFieldState(
            [NativeTypeName("DWORD")] uint dwFieldID,
            CREDENTIAL_PROVIDER_FIELD_STATE* pcpfs,
            CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE* pcpfis
        );

        [VtblIndex(8)]
        HRESULT GetStringValue(
            [NativeTypeName("DWORD")] uint dwFieldID,
            [NativeTypeName("LPWSTR *")] ushort** ppsz
        );

        [VtblIndex(9)]
        HRESULT GetBitmapValue([NativeTypeName("DWORD")] uint dwFieldID, HBITMAP* phbmp);

        [VtblIndex(10)]
        HRESULT GetCheckboxValue(
            [NativeTypeName("DWORD")] uint dwFieldID,
            BOOL* pbChecked,
            [NativeTypeName("LPWSTR *")] ushort** ppszLabel
        );

        [VtblIndex(11)]
        HRESULT GetSubmitButtonValue(
            [NativeTypeName("DWORD")] uint dwFieldID,
            [NativeTypeName("DWORD *")] uint* pdwAdjacentTo
        );

        [VtblIndex(12)]
        HRESULT GetComboBoxValueCount(
            [NativeTypeName("DWORD")] uint dwFieldID,
            [NativeTypeName("DWORD *")] uint* pcItems,
            [NativeTypeName("DWORD *")] uint* pdwSelectedItem
        );

        [VtblIndex(13)]
        HRESULT GetComboBoxValueAt(
            [NativeTypeName("DWORD")] uint dwFieldID,
            [NativeTypeName("DWORD")] uint dwItem,
            [NativeTypeName("LPWSTR *")] ushort** ppszItem
        );

        [VtblIndex(14)]
        HRESULT SetStringValue(
            [NativeTypeName("DWORD")] uint dwFieldID,
            [NativeTypeName("LPCWSTR")] ushort* psz
        );

        [VtblIndex(15)]
        HRESULT SetCheckboxValue([NativeTypeName("DWORD")] uint dwFieldID, BOOL bChecked);

        [VtblIndex(16)]
        HRESULT SetComboBoxSelectedValue(
            [NativeTypeName("DWORD")] uint dwFieldID,
            [NativeTypeName("DWORD")] uint dwSelectedItem
        );

        [VtblIndex(17)]
        HRESULT CommandLinkClicked([NativeTypeName("DWORD")] uint dwFieldID);

        [VtblIndex(18)]
        HRESULT GetSerialization(
            CREDENTIAL_PROVIDER_GET_SERIALIZATION_RESPONSE* pcpgsr,
            CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION* pcpcs,
            [NativeTypeName("LPWSTR *")] ushort** ppszOptionalStatusText,
            CREDENTIAL_PROVIDER_STATUS_ICON* pcpsiOptionalStatusIcon
        );

        [VtblIndex(19)]
        HRESULT ReportResult(
            [NativeTypeName("NTSTATUS")] int ntsStatus,
            [NativeTypeName("NTSTATUS")] int ntsSubstatus,
            [NativeTypeName("LPWSTR *")] ushort** ppszOptionalStatusText,
            CREDENTIAL_PROVIDER_STATUS_ICON* pcpsiOptionalStatusIcon
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

        [NativeTypeName("HRESULT (ICredentialProviderCredentialEvents *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ICredentialProviderCredentialEvents, int> Advise;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> UnAdvise;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> SetSelected;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SetDeselected;

        [NativeTypeName(
            "HRESULT (DWORD, CREDENTIAL_PROVIDER_FIELD_STATE *, CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            CREDENTIAL_PROVIDER_FIELD_STATE*,
            CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE*,
            int> GetFieldState;

        [NativeTypeName("HRESULT (DWORD, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, int> GetStringValue;

        [NativeTypeName("HRESULT (DWORD, HBITMAP *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, HBITMAP*, int> GetBitmapValue;

        [NativeTypeName("HRESULT (DWORD, BOOL *, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, BOOL*, ushort**, int> GetCheckboxValue;

        [NativeTypeName("HRESULT (DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetSubmitButtonValue;

        [NativeTypeName("HRESULT (DWORD, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, uint*, int> GetComboBoxValueCount;

        [NativeTypeName("HRESULT (DWORD, DWORD, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ushort**, int> GetComboBoxValueAt;

        [NativeTypeName("HRESULT (DWORD, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, int> SetStringValue;

        [NativeTypeName("HRESULT (DWORD, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, BOOL, int> SetCheckboxValue;

        [NativeTypeName("HRESULT (DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> SetComboBoxSelectedValue;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> CommandLinkClicked;

        [NativeTypeName(
            "HRESULT (CREDENTIAL_PROVIDER_GET_SERIALIZATION_RESPONSE *, CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION *, LPWSTR *, CREDENTIAL_PROVIDER_STATUS_ICON *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CREDENTIAL_PROVIDER_GET_SERIALIZATION_RESPONSE*,
            CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION*,
            ushort**,
            CREDENTIAL_PROVIDER_STATUS_ICON*,
            int> GetSerialization;

        [NativeTypeName(
            "HRESULT (NTSTATUS, NTSTATUS, LPWSTR *, CREDENTIAL_PROVIDER_STATUS_ICON *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            int,
            ushort**,
            CREDENTIAL_PROVIDER_STATUS_ICON*,
            int> ReportResult;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICredentialProviderCredential"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICredentialProviderCredential(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICredentialProviderCredential"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICredentialProviderCredential(Silk.NET.Windows.IUnknown value)
    {
        return new ICredentialProviderCredential(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICredentialProviderCredential"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICredentialProviderCredential"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICredentialProviderCredential value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
