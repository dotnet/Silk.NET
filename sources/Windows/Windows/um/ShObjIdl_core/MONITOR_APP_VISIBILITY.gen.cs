// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MONITOR_APP_VISIBILITY.xml' path='doc/member[@name="MONITOR_APP_VISIBILITY"]/*'/>
public enum MONITOR_APP_VISIBILITY
{
    /// <include file='MONITOR_APP_VISIBILITY.xml' path='doc/member[@name="MONITOR_APP_VISIBILITY.MAV_UNKNOWN"]/*'/>
    MAV_UNKNOWN = 0,
    /// <include file='MONITOR_APP_VISIBILITY.xml' path='doc/member[@name="MONITOR_APP_VISIBILITY.MAV_NO_APP_VISIBLE"]/*'/>
    MAV_NO_APP_VISIBLE = 1,
    /// <include file='MONITOR_APP_VISIBILITY.xml' path='doc/member[@name="MONITOR_APP_VISIBILITY.MAV_APP_VISIBLE"]/*'/>
    MAV_APP_VISIBLE = 2,
}