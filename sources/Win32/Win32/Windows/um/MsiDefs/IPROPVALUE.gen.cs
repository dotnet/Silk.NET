// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class IPROPVALUE
{
    [NativeTypeName("#define IPROPVALUE_EXECUTEMODE_NONE TEXT(\"NONE\")")]
    public const string IPROPVALUE_EXECUTEMODE_NONE = "NONE";

    [NativeTypeName("#define IPROPVALUE_EXECUTEMODE_SCRIPT TEXT(\"SCRIPT\")")]
    public const string IPROPVALUE_EXECUTEMODE_SCRIPT = "SCRIPT";

    [NativeTypeName("#define IPROPVALUE__CARRYINGNDP_URTREINSTALL TEXT(\"URTREINSTALL\")")]
    public const string IPROPVALUE__CARRYINGNDP_URTREINSTALL = "URTREINSTALL";

    [NativeTypeName("#define IPROPVALUE__CARRYINGNDP_URTUPGRADE TEXT(\"URTUPGRADE\")")]
    public const string IPROPVALUE__CARRYINGNDP_URTUPGRADE = "URTUPGRADE";

    [NativeTypeName("#define IPROPVALUE_MSI_RM_CONTROL_DISABLE TEXT(\"Disable\")")]
    public const string IPROPVALUE_MSI_RM_CONTROL_DISABLE = "Disable";

    [NativeTypeName("#define IPROPVALUE_MSI_RM_CONTROL_DISABLESHUTDOWN TEXT(\"DisableShutdown\")")]
    public const string IPROPVALUE_MSI_RM_CONTROL_DISABLESHUTDOWN = "DisableShutdown";

    [NativeTypeName("#define IPROPVALUE_FEATURE_ALL TEXT(\"ALL\")")]
    public const string IPROPVALUE_FEATURE_ALL = "ALL";

    [NativeTypeName("#define IPROPVALUE_RBCOST_PROMPT TEXT(\"P\")")]
    public const string IPROPVALUE_RBCOST_PROMPT = "P";

    [NativeTypeName("#define IPROPVALUE_RBCOST_SILENT TEXT(\"D\")")]
    public const string IPROPVALUE_RBCOST_SILENT = "D";

    [NativeTypeName("#define IPROPVALUE_RBCOST_FAIL TEXT(\"F\")")]
    public const string IPROPVALUE_RBCOST_FAIL = "F";
}
