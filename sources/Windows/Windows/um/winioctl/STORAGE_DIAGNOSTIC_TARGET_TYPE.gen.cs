// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STORAGE_DIAGNOSTIC_TARGET_TYPE.xml' path='doc/member[@name="STORAGE_DIAGNOSTIC_TARGET_TYPE"]/*'/>
public enum STORAGE_DIAGNOSTIC_TARGET_TYPE
{
    /// <include file='STORAGE_DIAGNOSTIC_TARGET_TYPE.xml' path='doc/member[@name="STORAGE_DIAGNOSTIC_TARGET_TYPE.StorageDiagnosticTargetTypeUndefined"]/*'/>
    StorageDiagnosticTargetTypeUndefined = 0,
    /// <include file='STORAGE_DIAGNOSTIC_TARGET_TYPE.xml' path='doc/member[@name="STORAGE_DIAGNOSTIC_TARGET_TYPE.StorageDiagnosticTargetTypePort"]/*'/>
    StorageDiagnosticTargetTypePort,
    /// <include file='STORAGE_DIAGNOSTIC_TARGET_TYPE.xml' path='doc/member[@name="STORAGE_DIAGNOSTIC_TARGET_TYPE.StorageDiagnosticTargetTypeMiniport"]/*'/>
    StorageDiagnosticTargetTypeMiniport,
    /// <include file='STORAGE_DIAGNOSTIC_TARGET_TYPE.xml' path='doc/member[@name="STORAGE_DIAGNOSTIC_TARGET_TYPE.StorageDiagnosticTargetTypeHbaFirmware"]/*'/>
    StorageDiagnosticTargetTypeHbaFirmware,
    /// <include file='STORAGE_DIAGNOSTIC_TARGET_TYPE.xml' path='doc/member[@name="STORAGE_DIAGNOSTIC_TARGET_TYPE.StorageDiagnosticTargetTypeMax"]/*'/>
    StorageDiagnosticTargetTypeMax,
}