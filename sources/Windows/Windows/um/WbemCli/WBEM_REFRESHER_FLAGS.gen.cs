// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WBEM_REFRESHER_FLAGS.xml' path='doc/member[@name="WBEM_REFRESHER_FLAGS"]/*'/>
public enum WBEM_REFRESHER_FLAGS
{
    /// <include file='WBEM_REFRESHER_FLAGS.xml' path='doc/member[@name="WBEM_REFRESHER_FLAGS.WBEM_FLAG_REFRESH_AUTO_RECONNECT"]/*'/>
    WBEM_FLAG_REFRESH_AUTO_RECONNECT = 0,
    /// <include file='WBEM_REFRESHER_FLAGS.xml' path='doc/member[@name="WBEM_REFRESHER_FLAGS.WBEM_FLAG_REFRESH_NO_AUTO_RECONNECT"]/*'/>
    WBEM_FLAG_REFRESH_NO_AUTO_RECONNECT = 1,
}