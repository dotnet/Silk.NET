// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='msidbCustomActionType.xml' path='doc/member[@name="msidbCustomActionType"]/*' />
public enum msidbCustomActionType
{
    /// <include file='msidbCustomActionType.xml' path='doc/member[@name="msidbCustomActionType.msidbCustomActionTypeDll"]/*' />
    msidbCustomActionTypeDll = 0x00000001,

    /// <include file='msidbCustomActionType.xml' path='doc/member[@name="msidbCustomActionType.msidbCustomActionTypeExe"]/*' />
    msidbCustomActionTypeExe = 0x00000002,

    /// <include file='msidbCustomActionType.xml' path='doc/member[@name="msidbCustomActionType.msidbCustomActionTypeTextData"]/*' />
    msidbCustomActionTypeTextData = 0x00000003,

    /// <include file='msidbCustomActionType.xml' path='doc/member[@name="msidbCustomActionType.msidbCustomActionTypeJScript"]/*' />
    msidbCustomActionTypeJScript = 0x00000005,

    /// <include file='msidbCustomActionType.xml' path='doc/member[@name="msidbCustomActionType.msidbCustomActionTypeVBScript"]/*' />
    msidbCustomActionTypeVBScript = 0x00000006,

    /// <include file='msidbCustomActionType.xml' path='doc/member[@name="msidbCustomActionType.msidbCustomActionTypeInstall"]/*' />
    msidbCustomActionTypeInstall = 0x00000007,

    /// <include file='msidbCustomActionType.xml' path='doc/member[@name="msidbCustomActionType.msidbCustomActionTypeBinaryData"]/*' />
    msidbCustomActionTypeBinaryData = 0x00000000,

    /// <include file='msidbCustomActionType.xml' path='doc/member[@name="msidbCustomActionType.msidbCustomActionTypeSourceFile"]/*' />
    msidbCustomActionTypeSourceFile = 0x00000010,

    /// <include file='msidbCustomActionType.xml' path='doc/member[@name="msidbCustomActionType.msidbCustomActionTypeDirectory"]/*' />
    msidbCustomActionTypeDirectory = 0x00000020,

    /// <include file='msidbCustomActionType.xml' path='doc/member[@name="msidbCustomActionType.msidbCustomActionTypeProperty"]/*' />
    msidbCustomActionTypeProperty = 0x00000030,

    /// <include file='msidbCustomActionType.xml' path='doc/member[@name="msidbCustomActionType.msidbCustomActionTypeContinue"]/*' />
    msidbCustomActionTypeContinue = 0x00000040,

    /// <include file='msidbCustomActionType.xml' path='doc/member[@name="msidbCustomActionType.msidbCustomActionTypeAsync"]/*' />
    msidbCustomActionTypeAsync = 0x00000080,

    /// <include file='msidbCustomActionType.xml' path='doc/member[@name="msidbCustomActionType.msidbCustomActionTypeFirstSequence"]/*' />
    msidbCustomActionTypeFirstSequence = 0x00000100,

    /// <include file='msidbCustomActionType.xml' path='doc/member[@name="msidbCustomActionType.msidbCustomActionTypeOncePerProcess"]/*' />
    msidbCustomActionTypeOncePerProcess = 0x00000200,

    /// <include file='msidbCustomActionType.xml' path='doc/member[@name="msidbCustomActionType.msidbCustomActionTypeClientRepeat"]/*' />
    msidbCustomActionTypeClientRepeat = 0x00000300,

    /// <include file='msidbCustomActionType.xml' path='doc/member[@name="msidbCustomActionType.msidbCustomActionTypeInScript"]/*' />
    msidbCustomActionTypeInScript = 0x00000400,

    /// <include file='msidbCustomActionType.xml' path='doc/member[@name="msidbCustomActionType.msidbCustomActionTypeRollback"]/*' />
    msidbCustomActionTypeRollback = 0x00000100,

    /// <include file='msidbCustomActionType.xml' path='doc/member[@name="msidbCustomActionType.msidbCustomActionTypeCommit"]/*' />
    msidbCustomActionTypeCommit = 0x00000200,

    /// <include file='msidbCustomActionType.xml' path='doc/member[@name="msidbCustomActionType.msidbCustomActionTypeNoImpersonate"]/*' />
    msidbCustomActionTypeNoImpersonate = 0x00000800,

    /// <include file='msidbCustomActionType.xml' path='doc/member[@name="msidbCustomActionType.msidbCustomActionTypeTSAware"]/*' />
    msidbCustomActionTypeTSAware = 0x00004000,

    /// <include file='msidbCustomActionType.xml' path='doc/member[@name="msidbCustomActionType.msidbCustomActionType64BitScript"]/*' />
    msidbCustomActionType64BitScript = 0x00001000,

    /// <include file='msidbCustomActionType.xml' path='doc/member[@name="msidbCustomActionType.msidbCustomActionTypeHideTarget"]/*' />
    msidbCustomActionTypeHideTarget = 0x00002000,

    /// <include file='msidbCustomActionType.xml' path='doc/member[@name="msidbCustomActionType.msidbCustomActionTypePatchUninstall"]/*' />
    msidbCustomActionTypePatchUninstall = 0x00008000,
}
