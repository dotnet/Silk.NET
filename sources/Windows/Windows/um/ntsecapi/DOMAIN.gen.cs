// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class DOMAIN
{
    [NativeTypeName("#define DOMAIN_PASSWORD_COMPLEX 0x00000001L")]
    public const int DOMAIN_PASSWORD_COMPLEX = 0x00000001;
    [NativeTypeName("#define DOMAIN_PASSWORD_NO_ANON_CHANGE 0x00000002L")]
    public const int DOMAIN_PASSWORD_NO_ANON_CHANGE = 0x00000002;
    [NativeTypeName("#define DOMAIN_PASSWORD_NO_CLEAR_CHANGE 0x00000004L")]
    public const int DOMAIN_PASSWORD_NO_CLEAR_CHANGE = 0x00000004;
    [NativeTypeName("#define DOMAIN_LOCKOUT_ADMINS 0x00000008L")]
    public const int DOMAIN_LOCKOUT_ADMINS = 0x00000008;
    [NativeTypeName("#define DOMAIN_PASSWORD_STORE_CLEARTEXT 0x00000010L")]
    public const int DOMAIN_PASSWORD_STORE_CLEARTEXT = 0x00000010;
    [NativeTypeName("#define DOMAIN_REFUSE_PASSWORD_CHANGE 0x00000020L")]
    public const int DOMAIN_REFUSE_PASSWORD_CHANGE = 0x00000020;
    [NativeTypeName("#define DOMAIN_NO_LM_OWF_CHANGE 0x00000040L")]
    public const int DOMAIN_NO_LM_OWF_CHANGE = 0x00000040;
}