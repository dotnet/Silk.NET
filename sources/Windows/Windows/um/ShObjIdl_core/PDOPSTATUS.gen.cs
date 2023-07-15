// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='PDOPSTATUS.xml' path='doc/member[@name="PDOPSTATUS"]/*'/>
public enum PDOPSTATUS
{
    /// <include file='PDOPSTATUS.xml' path='doc/member[@name="PDOPSTATUS.PDOPS_RUNNING"]/*'/>
    PDOPS_RUNNING = 1,
    /// <include file='PDOPSTATUS.xml' path='doc/member[@name="PDOPSTATUS.PDOPS_PAUSED"]/*'/>
    PDOPS_PAUSED = 2,
    /// <include file='PDOPSTATUS.xml' path='doc/member[@name="PDOPSTATUS.PDOPS_CANCELLED"]/*'/>
    PDOPS_CANCELLED = 3,
    /// <include file='PDOPSTATUS.xml' path='doc/member[@name="PDOPSTATUS.PDOPS_STOPPED"]/*'/>
    PDOPS_STOPPED = 4,
    /// <include file='PDOPSTATUS.xml' path='doc/member[@name="PDOPSTATUS.PDOPS_ERRORS"]/*'/>
    PDOPS_ERRORS = 5,
}