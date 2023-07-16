// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class CFSTR
{
    [NativeTypeName("#define CFSTR_ENTERPRISE_ID (TEXT(\"EnterpriseDataProtectionId\"))")]
    public const string CFSTR_ENTERPRISE_ID = ("EnterpriseDataProtectionId");
}