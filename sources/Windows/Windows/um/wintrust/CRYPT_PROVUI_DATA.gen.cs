// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CRYPT_PROVUI_DATA.xml' path='doc/member[@name="CRYPT_PROVUI_DATA"]/*'/>
public unsafe partial struct CRYPT_PROVUI_DATA
{
    /// <include file='CRYPT_PROVUI_DATA.xml' path='doc/member[@name="CRYPT_PROVUI_DATA.cbStruct"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbStruct;
    /// <include file='CRYPT_PROVUI_DATA.xml' path='doc/member[@name="CRYPT_PROVUI_DATA.dwFinalError"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFinalError;
    /// <include file='CRYPT_PROVUI_DATA.xml' path='doc/member[@name="CRYPT_PROVUI_DATA.pYesButtonText"]/*'/>
    [NativeTypeName("WCHAR *")]
    public ushort* pYesButtonText;
    /// <include file='CRYPT_PROVUI_DATA.xml' path='doc/member[@name="CRYPT_PROVUI_DATA.pNoButtonText"]/*'/>
    [NativeTypeName("WCHAR *")]
    public ushort* pNoButtonText;
    /// <include file='CRYPT_PROVUI_DATA.xml' path='doc/member[@name="CRYPT_PROVUI_DATA.pMoreInfoButtonText"]/*'/>
    [NativeTypeName("WCHAR *")]
    public ushort* pMoreInfoButtonText;
    /// <include file='CRYPT_PROVUI_DATA.xml' path='doc/member[@name="CRYPT_PROVUI_DATA.pAdvancedLinkText"]/*'/>
    [NativeTypeName("WCHAR *")]
    public ushort* pAdvancedLinkText;
    /// <include file='CRYPT_PROVUI_DATA.xml' path='doc/member[@name="CRYPT_PROVUI_DATA.pCopyActionText"]/*'/>
    [NativeTypeName("WCHAR *")]
    public ushort* pCopyActionText;
    /// <include file='CRYPT_PROVUI_DATA.xml' path='doc/member[@name="CRYPT_PROVUI_DATA.pCopyActionTextNoTS"]/*'/>
    [NativeTypeName("WCHAR *")]
    public ushort* pCopyActionTextNoTS;
    /// <include file='CRYPT_PROVUI_DATA.xml' path='doc/member[@name="CRYPT_PROVUI_DATA.pCopyActionTextNotSigned"]/*'/>
    [NativeTypeName("WCHAR *")]
    public ushort* pCopyActionTextNotSigned;
}