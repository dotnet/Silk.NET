// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='FILLSTATES.xml' path='doc/member[@name="FILLSTATES"]/*'/>
public enum FILLSTATES
{
    /// <include file='FILLSTATES.xml' path='doc/member[@name="FILLSTATES.PBFS_NORMAL"]/*'/>
    PBFS_NORMAL = 1,
    /// <include file='FILLSTATES.xml' path='doc/member[@name="FILLSTATES.PBFS_ERROR"]/*'/>
    PBFS_ERROR = 2,
    /// <include file='FILLSTATES.xml' path='doc/member[@name="FILLSTATES.PBFS_PAUSED"]/*'/>
    PBFS_PAUSED = 3,
    /// <include file='FILLSTATES.xml' path='doc/member[@name="FILLSTATES.PBFS_PARTIAL"]/*'/>
    PBFS_PARTIAL = 4,
}