// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='COPYFILE2_COPY_PHASE.xml' path='doc/member[@name="COPYFILE2_COPY_PHASE"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum COPYFILE2_COPY_PHASE
{
    /// <include file='COPYFILE2_COPY_PHASE.xml' path='doc/member[@name="COPYFILE2_COPY_PHASE.COPYFILE2_PHASE_NONE"]/*'/>
    COPYFILE2_PHASE_NONE = 0,
    /// <include file='COPYFILE2_COPY_PHASE.xml' path='doc/member[@name="COPYFILE2_COPY_PHASE.COPYFILE2_PHASE_PREPARE_SOURCE"]/*'/>
    COPYFILE2_PHASE_PREPARE_SOURCE,
    /// <include file='COPYFILE2_COPY_PHASE.xml' path='doc/member[@name="COPYFILE2_COPY_PHASE.COPYFILE2_PHASE_PREPARE_DEST"]/*'/>
    COPYFILE2_PHASE_PREPARE_DEST,
    /// <include file='COPYFILE2_COPY_PHASE.xml' path='doc/member[@name="COPYFILE2_COPY_PHASE.COPYFILE2_PHASE_READ_SOURCE"]/*'/>
    COPYFILE2_PHASE_READ_SOURCE,
    /// <include file='COPYFILE2_COPY_PHASE.xml' path='doc/member[@name="COPYFILE2_COPY_PHASE.COPYFILE2_PHASE_WRITE_DESTINATION"]/*'/>
    COPYFILE2_PHASE_WRITE_DESTINATION,
    /// <include file='COPYFILE2_COPY_PHASE.xml' path='doc/member[@name="COPYFILE2_COPY_PHASE.COPYFILE2_PHASE_SERVER_COPY"]/*'/>
    COPYFILE2_PHASE_SERVER_COPY,
    /// <include file='COPYFILE2_COPY_PHASE.xml' path='doc/member[@name="COPYFILE2_COPY_PHASE.COPYFILE2_PHASE_NAMEGRAFT_COPY"]/*'/>
    COPYFILE2_PHASE_NAMEGRAFT_COPY,
    /// <include file='COPYFILE2_COPY_PHASE.xml' path='doc/member[@name="COPYFILE2_COPY_PHASE.COPYFILE2_PHASE_MAX"]/*'/>
    COPYFILE2_PHASE_MAX,
}