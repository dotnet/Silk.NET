// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MSChapp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MSChapSrvChangePassword"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint MSChapSrvChangePassword([NativeTypeName("PWSTR")] ushort* ServerName, [NativeTypeName("PWSTR")] ushort* UserName, [NativeTypeName("BOOLEAN")] byte LmOldPresent, [NativeTypeName("PLM_OWF_PASSWORD")] LM_OWF_PASSWORD* LmOldOwfPassword, [NativeTypeName("PLM_OWF_PASSWORD")] LM_OWF_PASSWORD* LmNewOwfPassword, [NativeTypeName("PNT_OWF_PASSWORD")] LM_OWF_PASSWORD* NtOldOwfPassword, [NativeTypeName("PNT_OWF_PASSWORD")] LM_OWF_PASSWORD* NtNewOwfPassword);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MSChapSrvChangePassword2"]/*'/>
    [DllImport("advapi32", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint MSChapSrvChangePassword2([NativeTypeName("PWSTR")] ushort* ServerName, [NativeTypeName("PWSTR")] ushort* UserName, [NativeTypeName("PSAMPR_ENCRYPTED_USER_PASSWORD")] SAMPR_ENCRYPTED_USER_PASSWORD* NewPasswordEncryptedWithOldNt, [NativeTypeName("PENCRYPTED_NT_OWF_PASSWORD")] ENCRYPTED_LM_OWF_PASSWORD* OldNtOwfPasswordEncryptedWithNewNt, [NativeTypeName("BOOLEAN")] byte LmPresent, [NativeTypeName("PSAMPR_ENCRYPTED_USER_PASSWORD")] SAMPR_ENCRYPTED_USER_PASSWORD* NewPasswordEncryptedWithOldLm, [NativeTypeName("PENCRYPTED_LM_OWF_PASSWORD")] ENCRYPTED_LM_OWF_PASSWORD* OldLmOwfPasswordEncryptedWithNewLmOrNt);
    [NativeTypeName("#define CYPHER_BLOCK_LENGTH 8")]
    public const int CYPHER_BLOCK_LENGTH = 8;
}