// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WBEM_GENERIC_FLAG_TYPE.xml' path='doc/member[@name="WBEM_GENERIC_FLAG_TYPE"]/*'/>
public enum WBEM_GENERIC_FLAG_TYPE
{
    /// <include file='WBEM_GENERIC_FLAG_TYPE.xml' path='doc/member[@name="WBEM_GENERIC_FLAG_TYPE.WBEM_FLAG_RETURN_IMMEDIATELY"]/*'/>
    WBEM_FLAG_RETURN_IMMEDIATELY = 0x10,
    /// <include file='WBEM_GENERIC_FLAG_TYPE.xml' path='doc/member[@name="WBEM_GENERIC_FLAG_TYPE.WBEM_FLAG_RETURN_WBEM_COMPLETE"]/*'/>
    WBEM_FLAG_RETURN_WBEM_COMPLETE = 0,
    /// <include file='WBEM_GENERIC_FLAG_TYPE.xml' path='doc/member[@name="WBEM_GENERIC_FLAG_TYPE.WBEM_FLAG_BIDIRECTIONAL"]/*'/>
    WBEM_FLAG_BIDIRECTIONAL = 0,
    /// <include file='WBEM_GENERIC_FLAG_TYPE.xml' path='doc/member[@name="WBEM_GENERIC_FLAG_TYPE.WBEM_FLAG_FORWARD_ONLY"]/*'/>
    WBEM_FLAG_FORWARD_ONLY = 0x20,
    /// <include file='WBEM_GENERIC_FLAG_TYPE.xml' path='doc/member[@name="WBEM_GENERIC_FLAG_TYPE.WBEM_FLAG_NO_ERROR_OBJECT"]/*'/>
    WBEM_FLAG_NO_ERROR_OBJECT = 0x40,
    /// <include file='WBEM_GENERIC_FLAG_TYPE.xml' path='doc/member[@name="WBEM_GENERIC_FLAG_TYPE.WBEM_FLAG_RETURN_ERROR_OBJECT"]/*'/>
    WBEM_FLAG_RETURN_ERROR_OBJECT = 0,
    /// <include file='WBEM_GENERIC_FLAG_TYPE.xml' path='doc/member[@name="WBEM_GENERIC_FLAG_TYPE.WBEM_FLAG_SEND_STATUS"]/*'/>
    WBEM_FLAG_SEND_STATUS = 0x80,
    /// <include file='WBEM_GENERIC_FLAG_TYPE.xml' path='doc/member[@name="WBEM_GENERIC_FLAG_TYPE.WBEM_FLAG_DONT_SEND_STATUS"]/*'/>
    WBEM_FLAG_DONT_SEND_STATUS = 0,
    /// <include file='WBEM_GENERIC_FLAG_TYPE.xml' path='doc/member[@name="WBEM_GENERIC_FLAG_TYPE.WBEM_FLAG_ENSURE_LOCATABLE"]/*'/>
    WBEM_FLAG_ENSURE_LOCATABLE = 0x100,
    /// <include file='WBEM_GENERIC_FLAG_TYPE.xml' path='doc/member[@name="WBEM_GENERIC_FLAG_TYPE.WBEM_FLAG_DIRECT_READ"]/*'/>
    WBEM_FLAG_DIRECT_READ = 0x200,
    /// <include file='WBEM_GENERIC_FLAG_TYPE.xml' path='doc/member[@name="WBEM_GENERIC_FLAG_TYPE.WBEM_FLAG_SEND_ONLY_SELECTED"]/*'/>
    WBEM_FLAG_SEND_ONLY_SELECTED = 0,
    /// <include file='WBEM_GENERIC_FLAG_TYPE.xml' path='doc/member[@name="WBEM_GENERIC_FLAG_TYPE.WBEM_RETURN_WHEN_COMPLETE"]/*'/>
    WBEM_RETURN_WHEN_COMPLETE = 0,
    /// <include file='WBEM_GENERIC_FLAG_TYPE.xml' path='doc/member[@name="WBEM_GENERIC_FLAG_TYPE.WBEM_RETURN_IMMEDIATELY"]/*'/>
    WBEM_RETURN_IMMEDIATELY = 0x10,
    /// <include file='WBEM_GENERIC_FLAG_TYPE.xml' path='doc/member[@name="WBEM_GENERIC_FLAG_TYPE.WBEM_MASK_RESERVED_FLAGS"]/*'/>
    WBEM_MASK_RESERVED_FLAGS = 0x1f000,
    /// <include file='WBEM_GENERIC_FLAG_TYPE.xml' path='doc/member[@name="WBEM_GENERIC_FLAG_TYPE.WBEM_FLAG_USE_AMENDED_QUALIFIERS"]/*'/>
    WBEM_FLAG_USE_AMENDED_QUALIFIERS = 0x20000,
    /// <include file='WBEM_GENERIC_FLAG_TYPE.xml' path='doc/member[@name="WBEM_GENERIC_FLAG_TYPE.WBEM_FLAG_STRONG_VALIDATION"]/*'/>
    WBEM_FLAG_STRONG_VALIDATION = 0x100000,
}