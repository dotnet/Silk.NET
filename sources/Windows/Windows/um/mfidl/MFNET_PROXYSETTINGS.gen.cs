// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MFNET_PROXYSETTINGS.xml' path='doc/member[@name="MFNET_PROXYSETTINGS"]/*'/>
public enum MFNET_PROXYSETTINGS
{
    /// <include file='MFNET_PROXYSETTINGS.xml' path='doc/member[@name="MFNET_PROXYSETTINGS.MFNET_PROXYSETTING_NONE"]/*'/>
    MFNET_PROXYSETTING_NONE = 0,
    /// <include file='MFNET_PROXYSETTINGS.xml' path='doc/member[@name="MFNET_PROXYSETTINGS.MFNET_PROXYSETTING_MANUAL"]/*'/>
    MFNET_PROXYSETTING_MANUAL = 1,
    /// <include file='MFNET_PROXYSETTINGS.xml' path='doc/member[@name="MFNET_PROXYSETTINGS.MFNET_PROXYSETTING_AUTO"]/*'/>
    MFNET_PROXYSETTING_AUTO = 2,
    /// <include file='MFNET_PROXYSETTINGS.xml' path='doc/member[@name="MFNET_PROXYSETTINGS.MFNET_PROXYSETTING_BROWSER"]/*'/>
    MFNET_PROXYSETTING_BROWSER = 3,
}