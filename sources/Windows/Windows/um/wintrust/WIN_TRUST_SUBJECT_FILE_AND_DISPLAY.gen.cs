// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WIN_TRUST_SUBJECT_FILE_AND_DISPLAY.xml' path='doc/member[@name="WIN_TRUST_SUBJECT_FILE_AND_DISPLAY"]/*'/>
public unsafe partial struct WIN_TRUST_SUBJECT_FILE_AND_DISPLAY
{
    /// <include file='WIN_TRUST_SUBJECT_FILE_AND_DISPLAY.xml' path='doc/member[@name="WIN_TRUST_SUBJECT_FILE_AND_DISPLAY.hFile"]/*'/>
    public HANDLE hFile;
    /// <include file='WIN_TRUST_SUBJECT_FILE_AND_DISPLAY.xml' path='doc/member[@name="WIN_TRUST_SUBJECT_FILE_AND_DISPLAY.lpPath"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* lpPath;
    /// <include file='WIN_TRUST_SUBJECT_FILE_AND_DISPLAY.xml' path='doc/member[@name="WIN_TRUST_SUBJECT_FILE_AND_DISPLAY.lpDisplayName"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* lpDisplayName;
}