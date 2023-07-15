// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WBEM_UNSECAPP_FLAG_TYPE.xml' path='doc/member[@name="WBEM_UNSECAPP_FLAG_TYPE"]/*'/>
public enum WBEM_UNSECAPP_FLAG_TYPE
{
    /// <include file='WBEM_UNSECAPP_FLAG_TYPE.xml' path='doc/member[@name="WBEM_UNSECAPP_FLAG_TYPE.WBEM_FLAG_UNSECAPP_DEFAULT_CHECK_ACCESS"]/*'/>
    WBEM_FLAG_UNSECAPP_DEFAULT_CHECK_ACCESS = 0,
    /// <include file='WBEM_UNSECAPP_FLAG_TYPE.xml' path='doc/member[@name="WBEM_UNSECAPP_FLAG_TYPE.WBEM_FLAG_UNSECAPP_CHECK_ACCESS"]/*'/>
    WBEM_FLAG_UNSECAPP_CHECK_ACCESS = 1,
    /// <include file='WBEM_UNSECAPP_FLAG_TYPE.xml' path='doc/member[@name="WBEM_UNSECAPP_FLAG_TYPE.WBEM_FLAG_UNSECAPP_DONT_CHECK_ACCESS"]/*'/>
    WBEM_FLAG_UNSECAPP_DONT_CHECK_ACCESS = 2,
}