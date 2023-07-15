// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='msidbODBCDataSourceRegistration.xml' path='doc/member[@name="msidbODBCDataSourceRegistration"]/*'/>
public enum msidbODBCDataSourceRegistration
{
    /// <include file='msidbODBCDataSourceRegistration.xml' path='doc/member[@name="msidbODBCDataSourceRegistration.msidbODBCDataSourceRegistrationPerMachine"]/*'/>
    msidbODBCDataSourceRegistrationPerMachine = 0x00000000,
    /// <include file='msidbODBCDataSourceRegistration.xml' path='doc/member[@name="msidbODBCDataSourceRegistration.msidbODBCDataSourceRegistrationPerUser"]/*'/>
    msidbODBCDataSourceRegistrationPerUser = 0x00000001,
}