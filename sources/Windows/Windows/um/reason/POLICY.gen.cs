// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/reason.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class POLICY
{
    [NativeTypeName("#define POLICY_SHOWREASONUI_NEVER 0")]
    public const int POLICY_SHOWREASONUI_NEVER = 0;
    [NativeTypeName("#define POLICY_SHOWREASONUI_ALWAYS 1")]
    public const int POLICY_SHOWREASONUI_ALWAYS = 1;
    [NativeTypeName("#define POLICY_SHOWREASONUI_WORKSTATIONONLY 2")]
    public const int POLICY_SHOWREASONUI_WORKSTATIONONLY = 2;
    [NativeTypeName("#define POLICY_SHOWREASONUI_SERVERONLY 3")]
    public const int POLICY_SHOWREASONUI_SERVERONLY = 3;
}