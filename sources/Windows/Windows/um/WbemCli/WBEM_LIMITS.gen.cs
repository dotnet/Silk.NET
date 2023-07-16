// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WBEM_LIMITS.xml' path='doc/member[@name="WBEM_LIMITS"]/*'/>
public enum WBEM_LIMITS
{
    /// <include file='WBEM_LIMITS.xml' path='doc/member[@name="WBEM_LIMITS.WBEM_MAX_IDENTIFIER"]/*'/>
    WBEM_MAX_IDENTIFIER = 0x1000,
    /// <include file='WBEM_LIMITS.xml' path='doc/member[@name="WBEM_LIMITS.WBEM_MAX_QUERY"]/*'/>
    WBEM_MAX_QUERY = 0x4000,
    /// <include file='WBEM_LIMITS.xml' path='doc/member[@name="WBEM_LIMITS.WBEM_MAX_PATH"]/*'/>
    WBEM_MAX_PATH = 0x2000,
    /// <include file='WBEM_LIMITS.xml' path='doc/member[@name="WBEM_LIMITS.WBEM_MAX_OBJECT_NESTING"]/*'/>
    WBEM_MAX_OBJECT_NESTING = 64,
    /// <include file='WBEM_LIMITS.xml' path='doc/member[@name="WBEM_LIMITS.WBEM_MAX_USER_PROPERTIES"]/*'/>
    WBEM_MAX_USER_PROPERTIES = 1024,
}