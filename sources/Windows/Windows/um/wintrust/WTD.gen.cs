// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class WTD
{
    [NativeTypeName("#define WTD_UI_ALL 1")]
    public const int WTD_UI_ALL = 1;
    [NativeTypeName("#define WTD_UI_NONE 2")]
    public const int WTD_UI_NONE = 2;
    [NativeTypeName("#define WTD_UI_NOBAD 3")]
    public const int WTD_UI_NOBAD = 3;
    [NativeTypeName("#define WTD_UI_NOGOOD 4")]
    public const int WTD_UI_NOGOOD = 4;
    [NativeTypeName("#define WTD_REVOKE_NONE 0x00000000")]
    public const int WTD_REVOKE_NONE = 0x00000000;
    [NativeTypeName("#define WTD_REVOKE_WHOLECHAIN 0x00000001")]
    public const int WTD_REVOKE_WHOLECHAIN = 0x00000001;
    [NativeTypeName("#define WTD_CHOICE_FILE 1")]
    public const int WTD_CHOICE_FILE = 1;
    [NativeTypeName("#define WTD_CHOICE_CATALOG 2")]
    public const int WTD_CHOICE_CATALOG = 2;
    [NativeTypeName("#define WTD_CHOICE_BLOB 3")]
    public const int WTD_CHOICE_BLOB = 3;
    [NativeTypeName("#define WTD_CHOICE_SIGNER 4")]
    public const int WTD_CHOICE_SIGNER = 4;
    [NativeTypeName("#define WTD_CHOICE_CERT 5")]
    public const int WTD_CHOICE_CERT = 5;
    [NativeTypeName("#define WTD_STATEACTION_IGNORE 0x00000000")]
    public const int WTD_STATEACTION_IGNORE = 0x00000000;
    [NativeTypeName("#define WTD_STATEACTION_VERIFY 0x00000001")]
    public const int WTD_STATEACTION_VERIFY = 0x00000001;
    [NativeTypeName("#define WTD_STATEACTION_CLOSE 0x00000002")]
    public const int WTD_STATEACTION_CLOSE = 0x00000002;
    [NativeTypeName("#define WTD_STATEACTION_AUTO_CACHE 0x00000003")]
    public const int WTD_STATEACTION_AUTO_CACHE = 0x00000003;
    [NativeTypeName("#define WTD_STATEACTION_AUTO_CACHE_FLUSH 0x00000004")]
    public const int WTD_STATEACTION_AUTO_CACHE_FLUSH = 0x00000004;
    [NativeTypeName("#define WTD_PROV_FLAGS_MASK 0x0000FFFF")]
    public const int WTD_PROV_FLAGS_MASK = 0x0000FFFF;
    [NativeTypeName("#define WTD_USE_IE4_TRUST_FLAG 0x00000001")]
    public const int WTD_USE_IE4_TRUST_FLAG = 0x00000001;
    [NativeTypeName("#define WTD_NO_IE4_CHAIN_FLAG 0x00000002")]
    public const int WTD_NO_IE4_CHAIN_FLAG = 0x00000002;
    [NativeTypeName("#define WTD_NO_POLICY_USAGE_FLAG 0x00000004")]
    public const int WTD_NO_POLICY_USAGE_FLAG = 0x00000004;
    [NativeTypeName("#define WTD_REVOCATION_CHECK_NONE 0x00000010")]
    public const int WTD_REVOCATION_CHECK_NONE = 0x00000010;
    [NativeTypeName("#define WTD_REVOCATION_CHECK_END_CERT 0x00000020")]
    public const int WTD_REVOCATION_CHECK_END_CERT = 0x00000020;
    [NativeTypeName("#define WTD_REVOCATION_CHECK_CHAIN 0x00000040")]
    public const int WTD_REVOCATION_CHECK_CHAIN = 0x00000040;
    [NativeTypeName("#define WTD_REVOCATION_CHECK_CHAIN_EXCLUDE_ROOT 0x00000080")]
    public const int WTD_REVOCATION_CHECK_CHAIN_EXCLUDE_ROOT = 0x00000080;
    [NativeTypeName("#define WTD_SAFER_FLAG 0x00000100")]
    public const int WTD_SAFER_FLAG = 0x00000100;
    [NativeTypeName("#define WTD_HASH_ONLY_FLAG 0x00000200")]
    public const int WTD_HASH_ONLY_FLAG = 0x00000200;
    [NativeTypeName("#define WTD_USE_DEFAULT_OSVER_CHECK 0x00000400")]
    public const int WTD_USE_DEFAULT_OSVER_CHECK = 0x00000400;
    [NativeTypeName("#define WTD_LIFETIME_SIGNING_FLAG 0x00000800")]
    public const int WTD_LIFETIME_SIGNING_FLAG = 0x00000800;
    [NativeTypeName("#define WTD_CACHE_ONLY_URL_RETRIEVAL 0x00001000")]
    public const int WTD_CACHE_ONLY_URL_RETRIEVAL = 0x00001000;
    [NativeTypeName("#define WTD_DISABLE_MD2_MD4 0x00002000")]
    public const int WTD_DISABLE_MD2_MD4 = 0x00002000;
    [NativeTypeName("#define WTD_MOTW 0x00004000")]
    public const int WTD_MOTW = 0x00004000;
    [NativeTypeName("#define WTD_CODE_INTEGRITY_DRIVER_MODE 0x00008000")]
    public const int WTD_CODE_INTEGRITY_DRIVER_MODE = 0x00008000;
    [NativeTypeName("#define WTD_UICONTEXT_EXECUTE 0")]
    public const int WTD_UICONTEXT_EXECUTE = 0;
    [NativeTypeName("#define WTD_UICONTEXT_INSTALL 1")]
    public const int WTD_UICONTEXT_INSTALL = 1;
}