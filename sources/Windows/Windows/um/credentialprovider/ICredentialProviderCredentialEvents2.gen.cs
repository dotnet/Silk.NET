// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ICredentialProviderCredentialEvents2.xml' path='doc/member[@name="ICredentialProviderCredentialEvents2"]/*'/>
[Guid("B53C00B6-9922-4B78-B1F4-DDFE774DC39B")]
[NativeTypeName("struct ICredentialProviderCredentialEvents2 : ICredentialProviderCredentialEvents")]
[NativeInheritance("ICredentialProviderCredentialEvents")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct ICredentialProviderCredentialEvents2 : ICredentialProviderCredentialEvents2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICredentialProviderCredentialEvents2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICredentialProviderCredentialEvents2*, Guid*, void**, int> )(lpVtbl[0]))((ICredentialProviderCredentialEvents2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICredentialProviderCredentialEvents2*, uint> )(lpVtbl[1]))((ICredentialProviderCredentialEvents2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICredentialProviderCredentialEvents2*, uint> )(lpVtbl[2]))((ICredentialProviderCredentialEvents2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ICredentialProviderCredentialEvents.SetFieldState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetFieldState(ICredentialProviderCredential* pcpc, [NativeTypeName("DWORD")] uint dwFieldID, CREDENTIAL_PROVIDER_FIELD_STATE cpfs)
    {
        return ((delegate* unmanaged<ICredentialProviderCredentialEvents2*, ICredentialProviderCredential*, uint, CREDENTIAL_PROVIDER_FIELD_STATE, int> )(lpVtbl[3]))((ICredentialProviderCredentialEvents2*)Unsafe.AsPointer(ref this), pcpc, dwFieldID, cpfs);
    }

    /// <inheritdoc cref = "ICredentialProviderCredentialEvents.SetFieldInteractiveState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetFieldInteractiveState(ICredentialProviderCredential* pcpc, [NativeTypeName("DWORD")] uint dwFieldID, CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE cpfis)
    {
        return ((delegate* unmanaged<ICredentialProviderCredentialEvents2*, ICredentialProviderCredential*, uint, CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE, int> )(lpVtbl[4]))((ICredentialProviderCredentialEvents2*)Unsafe.AsPointer(ref this), pcpc, dwFieldID, cpfis);
    }

    /// <inheritdoc cref = "ICredentialProviderCredentialEvents.SetFieldString"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetFieldString(ICredentialProviderCredential* pcpc, [NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("LPCWSTR")] ushort* psz)
    {
        return ((delegate* unmanaged<ICredentialProviderCredentialEvents2*, ICredentialProviderCredential*, uint, ushort*, int> )(lpVtbl[5]))((ICredentialProviderCredentialEvents2*)Unsafe.AsPointer(ref this), pcpc, dwFieldID, psz);
    }

    /// <inheritdoc cref = "ICredentialProviderCredentialEvents.SetFieldCheckbox"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetFieldCheckbox(ICredentialProviderCredential* pcpc, [NativeTypeName("DWORD")] uint dwFieldID, BOOL bChecked, [NativeTypeName("LPCWSTR")] ushort* pszLabel)
    {
        return ((delegate* unmanaged<ICredentialProviderCredentialEvents2*, ICredentialProviderCredential*, uint, BOOL, ushort*, int> )(lpVtbl[6]))((ICredentialProviderCredentialEvents2*)Unsafe.AsPointer(ref this), pcpc, dwFieldID, bChecked, pszLabel);
    }

    /// <inheritdoc cref = "ICredentialProviderCredentialEvents.SetFieldBitmap"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetFieldBitmap(ICredentialProviderCredential* pcpc, [NativeTypeName("DWORD")] uint dwFieldID, HBITMAP hbmp)
    {
        return ((delegate* unmanaged<ICredentialProviderCredentialEvents2*, ICredentialProviderCredential*, uint, HBITMAP, int> )(lpVtbl[7]))((ICredentialProviderCredentialEvents2*)Unsafe.AsPointer(ref this), pcpc, dwFieldID, hbmp);
    }

    /// <inheritdoc cref = "ICredentialProviderCredentialEvents.SetFieldComboBoxSelectedItem"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetFieldComboBoxSelectedItem(ICredentialProviderCredential* pcpc, [NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("DWORD")] uint dwSelectedItem)
    {
        return ((delegate* unmanaged<ICredentialProviderCredentialEvents2*, ICredentialProviderCredential*, uint, uint, int> )(lpVtbl[8]))((ICredentialProviderCredentialEvents2*)Unsafe.AsPointer(ref this), pcpc, dwFieldID, dwSelectedItem);
    }

    /// <inheritdoc cref = "ICredentialProviderCredentialEvents.DeleteFieldComboBoxItem"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT DeleteFieldComboBoxItem(ICredentialProviderCredential* pcpc, [NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("DWORD")] uint dwItem)
    {
        return ((delegate* unmanaged<ICredentialProviderCredentialEvents2*, ICredentialProviderCredential*, uint, uint, int> )(lpVtbl[9]))((ICredentialProviderCredentialEvents2*)Unsafe.AsPointer(ref this), pcpc, dwFieldID, dwItem);
    }

    /// <inheritdoc cref = "ICredentialProviderCredentialEvents.AppendFieldComboBoxItem"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT AppendFieldComboBoxItem(ICredentialProviderCredential* pcpc, [NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("LPCWSTR")] ushort* pszItem)
    {
        return ((delegate* unmanaged<ICredentialProviderCredentialEvents2*, ICredentialProviderCredential*, uint, ushort*, int> )(lpVtbl[10]))((ICredentialProviderCredentialEvents2*)Unsafe.AsPointer(ref this), pcpc, dwFieldID, pszItem);
    }

    /// <inheritdoc cref = "ICredentialProviderCredentialEvents.SetFieldSubmitButton"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetFieldSubmitButton(ICredentialProviderCredential* pcpc, [NativeTypeName("DWORD")] uint dwFieldID, [NativeTypeName("DWORD")] uint dwAdjacentTo)
    {
        return ((delegate* unmanaged<ICredentialProviderCredentialEvents2*, ICredentialProviderCredential*, uint, uint, int> )(lpVtbl[11]))((ICredentialProviderCredentialEvents2*)Unsafe.AsPointer(ref this), pcpc, dwFieldID, dwAdjacentTo);
    }

    /// <inheritdoc cref = "ICredentialProviderCredentialEvents.OnCreatingWindow"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT OnCreatingWindow(HWND* phwndOwner)
    {
        return ((delegate* unmanaged<ICredentialProviderCredentialEvents2*, HWND*, int> )(lpVtbl[12]))((ICredentialProviderCredentialEvents2*)Unsafe.AsPointer(ref this), phwndOwner);
    }

    /// <include file='ICredentialProviderCredentialEvents2.xml' path='doc/member[@name="ICredentialProviderCredentialEvents2.BeginFieldUpdates"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT BeginFieldUpdates()
    {
        return ((delegate* unmanaged<ICredentialProviderCredentialEvents2*, int> )(lpVtbl[13]))((ICredentialProviderCredentialEvents2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICredentialProviderCredentialEvents2.xml' path='doc/member[@name="ICredentialProviderCredentialEvents2.EndFieldUpdates"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT EndFieldUpdates()
    {
        return ((delegate* unmanaged<ICredentialProviderCredentialEvents2*, int> )(lpVtbl[14]))((ICredentialProviderCredentialEvents2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICredentialProviderCredentialEvents2.xml' path='doc/member[@name="ICredentialProviderCredentialEvents2.SetFieldOptions"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetFieldOptions(ICredentialProviderCredential* credential, [NativeTypeName("DWORD")] uint fieldID, CREDENTIAL_PROVIDER_CREDENTIAL_FIELD_OPTIONS options)
    {
        return ((delegate* unmanaged<ICredentialProviderCredentialEvents2*, ICredentialProviderCredential*, uint, CREDENTIAL_PROVIDER_CREDENTIAL_FIELD_OPTIONS, int> )(lpVtbl[15]))((ICredentialProviderCredentialEvents2*)Unsafe.AsPointer(ref this), credential, fieldID, options);
    }

    public interface Interface : ICredentialProviderCredentialEvents.Interface
    {
        [VtblIndex(13)]
        HRESULT BeginFieldUpdates();
        [VtblIndex(14)]
        HRESULT EndFieldUpdates();
        [VtblIndex(15)]
        HRESULT SetFieldOptions(ICredentialProviderCredential* credential, [NativeTypeName("DWORD")] uint fieldID, CREDENTIAL_PROVIDER_CREDENTIAL_FIELD_OPTIONS options);
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
        [NativeTypeName("HRESULT (ICredentialProviderCredential *, DWORD, CREDENTIAL_PROVIDER_FIELD_STATE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ICredentialProviderCredential*, uint, CREDENTIAL_PROVIDER_FIELD_STATE, int> SetFieldState;
        [NativeTypeName("HRESULT (ICredentialProviderCredential *, DWORD, CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ICredentialProviderCredential*, uint, CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE, int> SetFieldInteractiveState;
        [NativeTypeName("HRESULT (ICredentialProviderCredential *, DWORD, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ICredentialProviderCredential*, uint, ushort*, int> SetFieldString;
        [NativeTypeName("HRESULT (ICredentialProviderCredential *, DWORD, BOOL, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ICredentialProviderCredential*, uint, BOOL, ushort*, int> SetFieldCheckbox;
        [NativeTypeName("HRESULT (ICredentialProviderCredential *, DWORD, HBITMAP) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ICredentialProviderCredential*, uint, HBITMAP, int> SetFieldBitmap;
        [NativeTypeName("HRESULT (ICredentialProviderCredential *, DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ICredentialProviderCredential*, uint, uint, int> SetFieldComboBoxSelectedItem;
        [NativeTypeName("HRESULT (ICredentialProviderCredential *, DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ICredentialProviderCredential*, uint, uint, int> DeleteFieldComboBoxItem;
        [NativeTypeName("HRESULT (ICredentialProviderCredential *, DWORD, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ICredentialProviderCredential*, uint, ushort*, int> AppendFieldComboBoxItem;
        [NativeTypeName("HRESULT (ICredentialProviderCredential *, DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ICredentialProviderCredential*, uint, uint, int> SetFieldSubmitButton;
        [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND*, int> OnCreatingWindow;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> BeginFieldUpdates;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> EndFieldUpdates;
        [NativeTypeName("HRESULT (ICredentialProviderCredential *, DWORD, CREDENTIAL_PROVIDER_CREDENTIAL_FIELD_OPTIONS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ICredentialProviderCredential*, uint, CREDENTIAL_PROVIDER_CREDENTIAL_FIELD_OPTIONS, int> SetFieldOptions;
    }
}