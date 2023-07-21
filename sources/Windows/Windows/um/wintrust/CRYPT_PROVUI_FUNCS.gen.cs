// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CRYPT_PROVUI_FUNCS.xml' path='doc/member[@name="CRYPT_PROVUI_FUNCS"]/*' />
public unsafe partial struct CRYPT_PROVUI_FUNCS
{
    /// <include file='CRYPT_PROVUI_FUNCS.xml' path='doc/member[@name="CRYPT_PROVUI_FUNCS.cbStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    /// <include file='CRYPT_PROVUI_FUNCS.xml' path='doc/member[@name="CRYPT_PROVUI_FUNCS.psUIData"]/*' />
    [NativeTypeName("struct _CRYPT_PROVUI_DATA *")]
    public CRYPT_PROVUI_DATA* psUIData;

    /// <include file='CRYPT_PROVUI_FUNCS.xml' path='doc/member[@name="CRYPT_PROVUI_FUNCS.pfnOnMoreInfoClick"]/*' />
    [NativeTypeName("PFN_PROVUI_CALL")]
    public delegate* unmanaged<HWND, CRYPT_PROVIDER_DATA*, BOOL> pfnOnMoreInfoClick;

    /// <include file='CRYPT_PROVUI_FUNCS.xml' path='doc/member[@name="CRYPT_PROVUI_FUNCS.pfnOnMoreInfoClickDefault"]/*' />
    [NativeTypeName("PFN_PROVUI_CALL")]
    public delegate* unmanaged<HWND, CRYPT_PROVIDER_DATA*, BOOL> pfnOnMoreInfoClickDefault;

    /// <include file='CRYPT_PROVUI_FUNCS.xml' path='doc/member[@name="CRYPT_PROVUI_FUNCS.pfnOnAdvancedClick"]/*' />
    [NativeTypeName("PFN_PROVUI_CALL")]
    public delegate* unmanaged<HWND, CRYPT_PROVIDER_DATA*, BOOL> pfnOnAdvancedClick;

    /// <include file='CRYPT_PROVUI_FUNCS.xml' path='doc/member[@name="CRYPT_PROVUI_FUNCS.pfnOnAdvancedClickDefault"]/*' />
    [NativeTypeName("PFN_PROVUI_CALL")]
    public delegate* unmanaged<HWND, CRYPT_PROVIDER_DATA*, BOOL> pfnOnAdvancedClickDefault;
}
