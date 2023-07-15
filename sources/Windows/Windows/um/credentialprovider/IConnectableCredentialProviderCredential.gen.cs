// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IConnectableCredentialProviderCredential.xml' path='doc/member[@name="IConnectableCredentialProviderCredential"]/*'/>
[Guid("9387928B-AC75-4BF9-8AB2-2B93C4A55290")]
[NativeTypeName("struct IConnectableCredentialProviderCredential : ICredentialProviderCredential")]
[NativeInheritance("ICredentialProviderCredential")]
public unsafe partial struct IConnectableCredentialProviderCredential : IConnectableCredentialProviderCredential.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IConnectableCredentialProviderCredential));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, Guid*, void**, int> )(lpVtbl[0]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, uint> )(lpVtbl[1]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, uint> )(lpVtbl[2]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ICredentialProviderCredential.Advise"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Advise(ICredentialProviderCredentialEvents* pcpce)
    {
        return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, ICredentialProviderCredentialEvents*, int> )(lpVtbl[3]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this), pcpce);
    }

    /// <inheritdoc cref = "ICredentialProviderCredential.UnAdvise"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnAdvise()
    {
        return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, int> )(lpVtbl[4]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ICredentialProviderCredential.SetSelected"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetSelected(BOOL* pbAutoLogon)
    {
        return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, BOOL*, int> )(lpVtbl[5]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this), pbAutoLogon);
    }

    /// <inheritdoc cref = "ICredentialProviderCredential.SetDeselected"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetDeselected()
    {
        return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, int> )(lpVtbl[6]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ICredentialProviderCredential.GetFieldState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFieldState([NativeTypeName("DWORD")] uint dwFieldID, CREDENTIAL_PROVIDER_FIELD_STATE* pcpfs, CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE* pcpfis)
    {
        return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, uint, CREDENTIAL_PROVIDER_FIELD_STATE*, CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE*, int> )(lpVtbl[7]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this), dwFieldID, pcpfs, pcpfis);
    }

    /// <inheritdoc cref = "ICredentialProviderCredential.GetStringValue"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetStringValue([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("LPWSTR *")] ushort** ppsz)
    {
        return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, uint, ushort**, int> )(lpVtbl[8]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this), dwFieldID, ppsz);
    }

    /// <inheritdoc cref = "ICredentialProviderCredential.GetBitmapValue"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetBitmapValue([NativeTypeName("DWORD")] uint dwFieldID, HBITMAP* phbmp)
    {
        return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, uint, HBITMAP*, int> )(lpVtbl[9]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this), dwFieldID, phbmp);
    }

    /// <inheritdoc cref = "ICredentialProviderCredential.GetCheckboxValue"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetCheckboxValue([NativeTypeName("DWORD")] uint dwFieldID, BOOL* pbChecked, [NativeTypeName("LPWSTR *")] ushort** ppszLabel)
    {
        return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, uint, BOOL*, ushort**, int> )(lpVtbl[10]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this), dwFieldID, pbChecked, ppszLabel);
    }

    /// <inheritdoc cref = "ICredentialProviderCredential.GetSubmitButtonValue"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetSubmitButtonValue([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("DWORD *")] uint* pdwAdjacentTo)
    {
        return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, uint, uint*, int> )(lpVtbl[11]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this), dwFieldID, pdwAdjacentTo);
    }

    /// <inheritdoc cref = "ICredentialProviderCredential.GetComboBoxValueCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetComboBoxValueCount([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("DWORD *")] uint* pcItems, [NativeTypeName("DWORD *")] uint* pdwSelectedItem)
    {
        return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, uint, uint*, uint*, int> )(lpVtbl[12]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this), dwFieldID, pcItems, pdwSelectedItem);
    }

    /// <inheritdoc cref = "ICredentialProviderCredential.GetComboBoxValueAt"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetComboBoxValueAt([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("DWORD")] uint dwItem, [NativeTypeName("LPWSTR *")] ushort** ppszItem)
    {
        return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, uint, uint, ushort**, int> )(lpVtbl[13]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this), dwFieldID, dwItem, ppszItem);
    }

    /// <inheritdoc cref = "ICredentialProviderCredential.SetStringValue"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetStringValue([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("LPCWSTR")] ushort* psz)
    {
        return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, uint, ushort*, int> )(lpVtbl[14]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this), dwFieldID, psz);
    }

    /// <inheritdoc cref = "ICredentialProviderCredential.SetCheckboxValue"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetCheckboxValue([NativeTypeName("DWORD")] uint dwFieldID, BOOL bChecked)
    {
        return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, uint, BOOL, int> )(lpVtbl[15]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this), dwFieldID, bChecked);
    }

    /// <inheritdoc cref = "ICredentialProviderCredential.SetComboBoxSelectedValue"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetComboBoxSelectedValue([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("DWORD")] uint dwSelectedItem)
    {
        return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, uint, uint, int> )(lpVtbl[16]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this), dwFieldID, dwSelectedItem);
    }

    /// <inheritdoc cref = "ICredentialProviderCredential.CommandLinkClicked"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CommandLinkClicked([NativeTypeName("DWORD")] uint dwFieldID)
    {
        return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, uint, int> )(lpVtbl[17]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this), dwFieldID);
    }

    /// <inheritdoc cref = "ICredentialProviderCredential.GetSerialization"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetSerialization(CREDENTIAL_PROVIDER_GET_SERIALIZATION_RESPONSE* pcpgsr, CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION* pcpcs, [NativeTypeName("LPWSTR *")] ushort** ppszOptionalStatusText, CREDENTIAL_PROVIDER_STATUS_ICON* pcpsiOptionalStatusIcon)
    {
        return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, CREDENTIAL_PROVIDER_GET_SERIALIZATION_RESPONSE*, CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION*, ushort**, CREDENTIAL_PROVIDER_STATUS_ICON*, int> )(lpVtbl[18]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this), pcpgsr, pcpcs, ppszOptionalStatusText, pcpsiOptionalStatusIcon);
    }

    /// <inheritdoc cref = "ICredentialProviderCredential.ReportResult"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT ReportResult([NativeTypeName("NTSTATUS")] int ntsStatus, [NativeTypeName("NTSTATUS")] int ntsSubstatus, [NativeTypeName("LPWSTR *")] ushort** ppszOptionalStatusText, CREDENTIAL_PROVIDER_STATUS_ICON* pcpsiOptionalStatusIcon)
    {
        return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, int, int, ushort**, CREDENTIAL_PROVIDER_STATUS_ICON*, int> )(lpVtbl[19]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this), ntsStatus, ntsSubstatus, ppszOptionalStatusText, pcpsiOptionalStatusIcon);
    }

    /// <include file='IConnectableCredentialProviderCredential.xml' path='doc/member[@name="IConnectableCredentialProviderCredential.Connect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT Connect(IQueryContinueWithStatus* pqcws)
    {
        return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, IQueryContinueWithStatus*, int> )(lpVtbl[20]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this), pqcws);
    }

    /// <include file='IConnectableCredentialProviderCredential.xml' path='doc/member[@name="IConnectableCredentialProviderCredential.Disconnect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT Disconnect()
    {
        return ((delegate* unmanaged<IConnectableCredentialProviderCredential*, int> )(lpVtbl[21]))((IConnectableCredentialProviderCredential*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : ICredentialProviderCredential.Interface
    {
        [VtblIndex(20)]
        HRESULT Connect(IQueryContinueWithStatus* pqcws);
        [VtblIndex(21)]
        HRESULT Disconnect();
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
        public delegate* unmanaged<TSelf*, ICredentialProviderCredentialEvents*, int> Advise;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> UnAdvise;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> SetSelected;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SetDeselected;
        [NativeTypeName("HRESULT (DWORD, CREDENTIAL_PROVIDER_FIELD_STATE *, CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, CREDENTIAL_PROVIDER_FIELD_STATE*, CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE*, int> GetFieldState;
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
        [NativeTypeName("HRESULT (CREDENTIAL_PROVIDER_GET_SERIALIZATION_RESPONSE *, CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION *, LPWSTR *, CREDENTIAL_PROVIDER_STATUS_ICON *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, CREDENTIAL_PROVIDER_GET_SERIALIZATION_RESPONSE*, CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION*, ushort**, CREDENTIAL_PROVIDER_STATUS_ICON*, int> GetSerialization;
        [NativeTypeName("HRESULT (NTSTATUS, NTSTATUS, LPWSTR *, CREDENTIAL_PROVIDER_STATUS_ICON *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, ushort**, CREDENTIAL_PROVIDER_STATUS_ICON*, int> ReportResult;
        [NativeTypeName("HRESULT (IQueryContinueWithStatus *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IQueryContinueWithStatus*, int> Connect;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Disconnect;
    }
}