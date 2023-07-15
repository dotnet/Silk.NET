// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WBEM_CONDITION_FLAG_TYPE.xml' path='doc/member[@name="WBEM_CONDITION_FLAG_TYPE"]/*'/>
public enum WBEM_CONDITION_FLAG_TYPE
{
    /// <include file='WBEM_CONDITION_FLAG_TYPE.xml' path='doc/member[@name="WBEM_CONDITION_FLAG_TYPE.WBEM_FLAG_ALWAYS"]/*'/>
    WBEM_FLAG_ALWAYS = 0,
    /// <include file='WBEM_CONDITION_FLAG_TYPE.xml' path='doc/member[@name="WBEM_CONDITION_FLAG_TYPE.WBEM_FLAG_ONLY_IF_TRUE"]/*'/>
    WBEM_FLAG_ONLY_IF_TRUE = 0x1,
    /// <include file='WBEM_CONDITION_FLAG_TYPE.xml' path='doc/member[@name="WBEM_CONDITION_FLAG_TYPE.WBEM_FLAG_ONLY_IF_FALSE"]/*'/>
    WBEM_FLAG_ONLY_IF_FALSE = 0x2,
    /// <include file='WBEM_CONDITION_FLAG_TYPE.xml' path='doc/member[@name="WBEM_CONDITION_FLAG_TYPE.WBEM_FLAG_ONLY_IF_IDENTICAL"]/*'/>
    WBEM_FLAG_ONLY_IF_IDENTICAL = 0x3,
    /// <include file='WBEM_CONDITION_FLAG_TYPE.xml' path='doc/member[@name="WBEM_CONDITION_FLAG_TYPE.WBEM_MASK_PRIMARY_CONDITION"]/*'/>
    WBEM_MASK_PRIMARY_CONDITION = 0x3,
    /// <include file='WBEM_CONDITION_FLAG_TYPE.xml' path='doc/member[@name="WBEM_CONDITION_FLAG_TYPE.WBEM_FLAG_KEYS_ONLY"]/*'/>
    WBEM_FLAG_KEYS_ONLY = 0x4,
    /// <include file='WBEM_CONDITION_FLAG_TYPE.xml' path='doc/member[@name="WBEM_CONDITION_FLAG_TYPE.WBEM_FLAG_REFS_ONLY"]/*'/>
    WBEM_FLAG_REFS_ONLY = 0x8,
    /// <include file='WBEM_CONDITION_FLAG_TYPE.xml' path='doc/member[@name="WBEM_CONDITION_FLAG_TYPE.WBEM_FLAG_LOCAL_ONLY"]/*'/>
    WBEM_FLAG_LOCAL_ONLY = 0x10,
    /// <include file='WBEM_CONDITION_FLAG_TYPE.xml' path='doc/member[@name="WBEM_CONDITION_FLAG_TYPE.WBEM_FLAG_PROPAGATED_ONLY"]/*'/>
    WBEM_FLAG_PROPAGATED_ONLY = 0x20,
    /// <include file='WBEM_CONDITION_FLAG_TYPE.xml' path='doc/member[@name="WBEM_CONDITION_FLAG_TYPE.WBEM_FLAG_SYSTEM_ONLY"]/*'/>
    WBEM_FLAG_SYSTEM_ONLY = 0x30,
    /// <include file='WBEM_CONDITION_FLAG_TYPE.xml' path='doc/member[@name="WBEM_CONDITION_FLAG_TYPE.WBEM_FLAG_NONSYSTEM_ONLY"]/*'/>
    WBEM_FLAG_NONSYSTEM_ONLY = 0x40,
    /// <include file='WBEM_CONDITION_FLAG_TYPE.xml' path='doc/member[@name="WBEM_CONDITION_FLAG_TYPE.WBEM_MASK_CONDITION_ORIGIN"]/*'/>
    WBEM_MASK_CONDITION_ORIGIN = 0x70,
    /// <include file='WBEM_CONDITION_FLAG_TYPE.xml' path='doc/member[@name="WBEM_CONDITION_FLAG_TYPE.WBEM_FLAG_CLASS_OVERRIDES_ONLY"]/*'/>
    WBEM_FLAG_CLASS_OVERRIDES_ONLY = 0x100,
    /// <include file='WBEM_CONDITION_FLAG_TYPE.xml' path='doc/member[@name="WBEM_CONDITION_FLAG_TYPE.WBEM_FLAG_CLASS_LOCAL_AND_OVERRIDES"]/*'/>
    WBEM_FLAG_CLASS_LOCAL_AND_OVERRIDES = 0x200,
    /// <include file='WBEM_CONDITION_FLAG_TYPE.xml' path='doc/member[@name="WBEM_CONDITION_FLAG_TYPE.WBEM_MASK_CLASS_CONDITION"]/*'/>
    WBEM_MASK_CLASS_CONDITION = 0x300,
}