// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SoftPub.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class SP
{
    [NativeTypeName("#define SP_POLICY_PROVIDER_DLL_NAME L\"WINTRUST.DLL\"")]
    public const string SP_POLICY_PROVIDER_DLL_NAME = "WINTRUST.DLL";

    [NativeTypeName("#define SP_INIT_FUNCTION L\"SoftpubInitialize\"")]
    public const string SP_INIT_FUNCTION = "SoftpubInitialize";

    [NativeTypeName("#define SP_OBJTRUST_FUNCTION L\"SoftpubLoadMessage\"")]
    public const string SP_OBJTRUST_FUNCTION = "SoftpubLoadMessage";

    [NativeTypeName("#define SP_SIGTRUST_FUNCTION L\"SoftpubLoadSignature\"")]
    public const string SP_SIGTRUST_FUNCTION = "SoftpubLoadSignature";

    [NativeTypeName("#define SP_CHKCERT_FUNCTION L\"SoftpubCheckCert\"")]
    public const string SP_CHKCERT_FUNCTION = "SoftpubCheckCert";

    [NativeTypeName("#define SP_FINALPOLICY_FUNCTION L\"SoftpubAuthenticode\"")]
    public const string SP_FINALPOLICY_FUNCTION = "SoftpubAuthenticode";

    [NativeTypeName("#define SP_CLEANUPPOLICY_FUNCTION L\"SoftpubCleanup\"")]
    public const string SP_CLEANUPPOLICY_FUNCTION = "SoftpubCleanup";

    [NativeTypeName("#define SP_TESTDUMPPOLICY_FUNCTION_TEST L\"SoftpubDumpStructure\"")]
    public const string SP_TESTDUMPPOLICY_FUNCTION_TEST = "SoftpubDumpStructure";

    [NativeTypeName("#define SP_GENERIC_CERT_INIT_FUNCTION L\"SoftpubDefCertInit\"")]
    public const string SP_GENERIC_CERT_INIT_FUNCTION = "SoftpubDefCertInit";
}
