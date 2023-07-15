// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WIN_TRUST_SUBJECT_FILE.xml' path='doc/member[@name="WIN_TRUST_SUBJECT_FILE"]/*'/>
public unsafe partial struct WIN_TRUST_SUBJECT_FILE
{
    /// <include file='WIN_TRUST_SUBJECT_FILE.xml' path='doc/member[@name="WIN_TRUST_SUBJECT_FILE.hFile"]/*'/>
    public HANDLE hFile;
    /// <include file='WIN_TRUST_SUBJECT_FILE.xml' path='doc/member[@name="WIN_TRUST_SUBJECT_FILE.lpPath"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* lpPath;
}