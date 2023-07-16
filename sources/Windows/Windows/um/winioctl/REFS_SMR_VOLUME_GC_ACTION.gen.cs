// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='REFS_SMR_VOLUME_GC_ACTION.xml' path='doc/member[@name="REFS_SMR_VOLUME_GC_ACTION"]/*'/>
public enum REFS_SMR_VOLUME_GC_ACTION
{
    /// <include file='REFS_SMR_VOLUME_GC_ACTION.xml' path='doc/member[@name="REFS_SMR_VOLUME_GC_ACTION.SmrGcActionStart"]/*'/>
    SmrGcActionStart = 1,
    /// <include file='REFS_SMR_VOLUME_GC_ACTION.xml' path='doc/member[@name="REFS_SMR_VOLUME_GC_ACTION.SmrGcActionStartFullSpeed"]/*'/>
    SmrGcActionStartFullSpeed = 2,
    /// <include file='REFS_SMR_VOLUME_GC_ACTION.xml' path='doc/member[@name="REFS_SMR_VOLUME_GC_ACTION.SmrGcActionPause"]/*'/>
    SmrGcActionPause = 3,
    /// <include file='REFS_SMR_VOLUME_GC_ACTION.xml' path='doc/member[@name="REFS_SMR_VOLUME_GC_ACTION.SmrGcActionStop"]/*'/>
    SmrGcActionStop = 4,
}