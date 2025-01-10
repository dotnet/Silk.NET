// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum msidbCustomActionType
{
    msidbCustomActionTypeDll = 0x00000001,
    msidbCustomActionTypeExe = 0x00000002,
    msidbCustomActionTypeTextData = 0x00000003,
    msidbCustomActionTypeJScript = 0x00000005,
    msidbCustomActionTypeVBScript = 0x00000006,
    msidbCustomActionTypeInstall = 0x00000007,
    msidbCustomActionTypeBinaryData = 0x00000000,
    msidbCustomActionTypeSourceFile = 0x00000010,
    msidbCustomActionTypeDirectory = 0x00000020,
    msidbCustomActionTypeProperty = 0x00000030,
    msidbCustomActionTypeContinue = 0x00000040,
    msidbCustomActionTypeAsync = 0x00000080,
    msidbCustomActionTypeFirstSequence = 0x00000100,
    msidbCustomActionTypeOncePerProcess = 0x00000200,
    msidbCustomActionTypeClientRepeat = 0x00000300,
    msidbCustomActionTypeInScript = 0x00000400,
    msidbCustomActionTypeRollback = 0x00000100,
    msidbCustomActionTypeCommit = 0x00000200,
    msidbCustomActionTypeNoImpersonate = 0x00000800,
    msidbCustomActionTypeTSAware = 0x00004000,
    msidbCustomActionType64BitScript = 0x00001000,
    msidbCustomActionTypeHideTarget = 0x00002000,
    msidbCustomActionTypePatchUninstall = 0x00008000,
}
