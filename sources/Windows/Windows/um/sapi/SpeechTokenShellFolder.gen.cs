// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SpeechTokenShellFolder.xml' path='doc/member[@name="SpeechTokenShellFolder"]/*'/>
public enum SpeechTokenShellFolder
{
    /// <include file='SpeechTokenShellFolder.xml' path='doc/member[@name="SpeechTokenShellFolder.STSF_AppData"]/*'/>
    STSF_AppData = 0x1a,
    /// <include file='SpeechTokenShellFolder.xml' path='doc/member[@name="SpeechTokenShellFolder.STSF_LocalAppData"]/*'/>
    STSF_LocalAppData = 0x1c,
    /// <include file='SpeechTokenShellFolder.xml' path='doc/member[@name="SpeechTokenShellFolder.STSF_CommonAppData"]/*'/>
    STSF_CommonAppData = 0x23,
    /// <include file='SpeechTokenShellFolder.xml' path='doc/member[@name="SpeechTokenShellFolder.STSF_FlagCreate"]/*'/>
    STSF_FlagCreate = 0x8000,
}