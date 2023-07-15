// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WBEM_SECURITY_FLAGS.xml' path='doc/member[@name="WBEM_SECURITY_FLAGS"]/*'/>
public enum WBEM_SECURITY_FLAGS
{
    /// <include file='WBEM_SECURITY_FLAGS.xml' path='doc/member[@name="WBEM_SECURITY_FLAGS.WBEM_ENABLE"]/*'/>
    WBEM_ENABLE = 1,
    /// <include file='WBEM_SECURITY_FLAGS.xml' path='doc/member[@name="WBEM_SECURITY_FLAGS.WBEM_METHOD_EXECUTE"]/*'/>
    WBEM_METHOD_EXECUTE = 2,
    /// <include file='WBEM_SECURITY_FLAGS.xml' path='doc/member[@name="WBEM_SECURITY_FLAGS.WBEM_FULL_WRITE_REP"]/*'/>
    WBEM_FULL_WRITE_REP = 4,
    /// <include file='WBEM_SECURITY_FLAGS.xml' path='doc/member[@name="WBEM_SECURITY_FLAGS.WBEM_PARTIAL_WRITE_REP"]/*'/>
    WBEM_PARTIAL_WRITE_REP = 8,
    /// <include file='WBEM_SECURITY_FLAGS.xml' path='doc/member[@name="WBEM_SECURITY_FLAGS.WBEM_WRITE_PROVIDER"]/*'/>
    WBEM_WRITE_PROVIDER = 0x10,
    /// <include file='WBEM_SECURITY_FLAGS.xml' path='doc/member[@name="WBEM_SECURITY_FLAGS.WBEM_REMOTE_ACCESS"]/*'/>
    WBEM_REMOTE_ACCESS = 0x20,
    /// <include file='WBEM_SECURITY_FLAGS.xml' path='doc/member[@name="WBEM_SECURITY_FLAGS.WBEM_RIGHT_SUBSCRIBE"]/*'/>
    WBEM_RIGHT_SUBSCRIBE = 0x40,
    /// <include file='WBEM_SECURITY_FLAGS.xml' path='doc/member[@name="WBEM_SECURITY_FLAGS.WBEM_RIGHT_PUBLISH"]/*'/>
    WBEM_RIGHT_PUBLISH = 0x80,
}