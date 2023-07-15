// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ICredentialProviderCredential2.xml' path='doc/member[@name="ICredentialProviderCredential2"]/*'/>
[Guid("FD672C54-40EA-4D6E-9B49-CFB1A7507BD7")]
[NativeTypeName("struct ICredentialProviderCredential2 : ICredentialProviderCredential")]
[NativeInheritance("ICredentialProviderCredential")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct ICredentialProviderCredential2 : ICredentialProviderCredential2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICredentialProviderCredential2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICredentialProviderCredential2*, Guid*, void**, int> )(lpVtbl[0]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICredentialProviderCredential2*, uint> )(lpVtbl[1]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICredentialProviderCredential2*, uint> )(lpVtbl[2]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ICredentialProviderCredential.Advise"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Advise(ICredentialProviderCredentialEvents* pcpce)
    {
        return ((delegate* unmanaged<ICredentialProviderCredential2*, ICredentialProviderCredentialEvents*, int> )(lpVtbl[3]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this), pcpce);
    }

    /// <inheritdoc cref = "ICredentialProviderCredential.UnAdvise"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnAdvise()
    {
        return ((delegate* unmanaged<ICredentialProviderCredential2*, int> )(lpVtbl[4]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ICredentialProviderCredential.SetSelected"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetSelected(BOOL* pbAutoLogon)
    {
        return ((delegate* unmanaged<ICredentialProviderCredential2*, BOOL*, int> )(lpVtbl[5]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this), pbAutoLogon);
    }

    /// <inheritdoc cref = "ICredentialProviderCredential.SetDeselected"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetDeselected()
    {
        return ((delegate* unmanaged<ICredentialProviderCredential2*, int> )(lpVtbl[6]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ICredentialProviderCredential.GetFieldState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFieldState([NativeTypeName("DWORD")] uint dwFieldID, CREDENTIAL_PROVIDER_FIELD_STATE* pcpfs, CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE* pcpfis)
    {
        return ((delegate* unmanaged<ICredentialProviderCredential2*, uint, CREDENTIAL_PROVIDER_FIELD_STATE*, CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE*, int> )(lpVtbl[7]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this), dwFieldID, pcpfs, pcpfis);
    }

    /// <inheritdoc cref = "ICredentialProviderCredential.GetStringValue"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetStringValue([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("LPWSTR *")] ushort** ppsz)
    {
        return ((delegate* unmanaged<ICredentialProviderCredential2*, uint, ushort**, int> )(lpVtbl[8]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this), dwFieldID, ppsz);
    }

    /// <inheritdoc cref = "ICredentialProviderCredential.GetBitmapValue"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetBitmapValue([NativeTypeName("DWORD")] uint dwFieldID, HBITMAP* phbmp)
    {
        return ((delegate* unmanaged<ICredentialProviderCredential2*, uint, HBITMAP*, int> )(lpVtbl[9]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this), dwFieldID, phbmp);
    }

    /// <inheritdoc cref = "ICredentialProviderCredential.GetCheckboxValue"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetCheckboxValue([NativeTypeName("DWORD")] uint dwFieldID, BOOL* pbChecked, [NativeTypeName("LPWSTR *")] ushort** ppszLabel)
    {
        return ((delegate* unmanaged<ICredentialProviderCredential2*, uint, BOOL*, ushort**, int> )(lpVtbl[10]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this), dwFieldID, pbChecked, ppszLabel);
    }

    /// <inheritdoc cref = "ICredentialProviderCredential.GetSubmitButtonValue"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetSubmitButtonValue([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("DWORD *")] uint* pdwAdjacentTo)
    {
        return ((delegate* unmanaged<ICredentialProviderCredential2*, uint, uint*, int> )(lpVtbl[11]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this), dwFieldID, pdwAdjacentTo);
    }

    /// <inheritdoc cref = "ICredentialProviderCredential.GetComboBoxValueCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetComboBoxValueCount([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("DWORD *")] uint* pcItems, [NativeTypeName("DWORD *")] uint* pdwSelectedItem)
    {
        return ((delegate* unmanaged<ICredentialProviderCredential2*, uint, uint*, uint*, int> )(lpVtbl[12]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this), dwFieldID, pcItems, pdwSelectedItem);
    }

    /// <inheritdoc cref = "ICredentialProviderCredential.GetComboBoxValueAt"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetComboBoxValueAt([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("DWORD")] uint dwItem, [NativeTypeName("LPWSTR *")] ushort** ppszItem)
    {
        return ((delegate* unmanaged<ICredentialProviderCredential2*, uint, uint, ushort**, int> )(lpVtbl[13]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this), dwFieldID, dwItem, ppszItem);
    }

    /// <inheritdoc cref = "ICredentialProviderCredential.SetStringValue"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetStringValue([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("LPCWSTR")] ushort* psz)
    {
        return ((delegate* unmanaged<ICredentialProviderCredential2*, uint, ushort*, int> )(lpVtbl[14]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this), dwFieldID, psz);
    }

    /// <inheritdoc cref = "ICredentialProviderCredential.SetCheckboxValue"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetCheckboxValue([NativeTypeName("DWORD")] uint dwFieldID, BOOL bChecked)
    {
        return ((delegate* unmanaged<ICredentialProviderCredential2*, uint, BOOL, int> )(lpVtbl[15]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this), dwFieldID, bChecked);
    }

    /// <inheritdoc cref = "ICredentialProviderCredential.SetComboBoxSelectedValue"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetComboBoxSelectedValue([NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("DWORD")] uint dwSelectedItem)
    {
        return ((delegate* unmanaged<ICredentialProviderCredential2*, uint, uint, int> )(lpVtbl[16]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this), dwFieldID, dwSelectedItem);
    }

    /// <inheritdoc cref = "ICredentialProviderCredential.CommandLinkClicked"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CommandLinkClicked([NativeTypeName("DWORD")] uint dwFieldID)
    {
        return ((delegate* unmanaged<ICredentialProviderCredential2*, uint, int> )(lpVtbl[17]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this), dwFieldID);
    }

    /// <inheritdoc cref = "ICredentialProviderCredential.GetSerialization"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetSerialization(CREDENTIAL_PROVIDER_GET_SERIALIZATION_RESPONSE* pcpgsr, CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION* pcpcs, [NativeTypeName("LPWSTR *")] ushort** ppszOptionalStatusText, CREDENTIAL_PROVIDER_STATUS_ICON* pcpsiOptionalStatusIcon)
    {
        return ((delegate* unmanaged<ICredentialProviderCredential2*, CREDENTIAL_PROVIDER_GET_SERIALIZATION_RESPONSE*, CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION*, ushort**, CREDENTIAL_PROVIDER_STATUS_ICON*, int> )(lpVtbl[18]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this), pcpgsr, pcpcs, ppszOptionalStatusText, pcpsiOptionalStatusIcon);
    }

    /// <inheritdoc cref = "ICredentialProviderCredential.ReportResult"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT ReportResult([NativeTypeName("NTSTATUS")] int ntsStatus, [NativeTypeName("NTSTATUS")] int ntsSubstatus, [NativeTypeName("LPWSTR *")] ushort** ppszOptionalStatusText, CREDENTIAL_PROVIDER_STATUS_ICON* pcpsiOptionalStatusIcon)
    {
        return ((delegate* unmanaged<ICredentialProviderCredential2*, int, int, ushort**, CREDENTIAL_PROVIDER_STATUS_ICON*, int> )(lpVtbl[19]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this), ntsStatus, ntsSubstatus, ppszOptionalStatusText, pcpsiOptionalStatusIcon);
    }

    /// <include file='ICredentialProviderCredential2.xml' path='doc/member[@name="ICredentialProviderCredential2.GetUserSid"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetUserSid([NativeTypeName("LPWSTR *")] ushort** sid)
    {
        return ((delegate* unmanaged<ICredentialProviderCredential2*, ushort**, int> )(lpVtbl[20]))((ICredentialProviderCredential2*)Unsafe.AsPointer(ref this), sid);
    }

    public interface Interface : ICredentialProviderCredential.Interface
    {
        [VtblIndex(20)]
        HRESULT GetUserSid([NativeTypeName("LPWSTR *")] ushort** sid);
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
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetUserSid;
    }
}