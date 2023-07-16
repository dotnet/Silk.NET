// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='COMSD.xml' path='doc/member[@name="COMSD"]/*'/>
public enum COMSD
{
    /// <include file='COMSD.xml' path='doc/member[@name="COMSD.SD_LAUNCHPERMISSIONS"]/*'/>
    SD_LAUNCHPERMISSIONS = 0,
    /// <include file='COMSD.xml' path='doc/member[@name="COMSD.SD_ACCESSPERMISSIONS"]/*'/>
    SD_ACCESSPERMISSIONS = 1,
    /// <include file='COMSD.xml' path='doc/member[@name="COMSD.SD_LAUNCHRESTRICTIONS"]/*'/>
    SD_LAUNCHRESTRICTIONS = 2,
    /// <include file='COMSD.xml' path='doc/member[@name="COMSD.SD_ACCESSRESTRICTIONS"]/*'/>
    SD_ACCESSRESTRICTIONS = 3,
}