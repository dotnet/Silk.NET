// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='IMAGE_POLICY_ENTRY_TYPE.xml' path='doc/member[@name="IMAGE_POLICY_ENTRY_TYPE"]/*'/>
public enum IMAGE_POLICY_ENTRY_TYPE
{
    /// <include file='IMAGE_POLICY_ENTRY_TYPE.xml' path='doc/member[@name="IMAGE_POLICY_ENTRY_TYPE.ImagePolicyEntryTypeNone"]/*'/>
    ImagePolicyEntryTypeNone = 0,
    /// <include file='IMAGE_POLICY_ENTRY_TYPE.xml' path='doc/member[@name="IMAGE_POLICY_ENTRY_TYPE.ImagePolicyEntryTypeBool"]/*'/>
    ImagePolicyEntryTypeBool,
    /// <include file='IMAGE_POLICY_ENTRY_TYPE.xml' path='doc/member[@name="IMAGE_POLICY_ENTRY_TYPE.ImagePolicyEntryTypeInt8"]/*'/>
    ImagePolicyEntryTypeInt8,
    /// <include file='IMAGE_POLICY_ENTRY_TYPE.xml' path='doc/member[@name="IMAGE_POLICY_ENTRY_TYPE.ImagePolicyEntryTypeUInt8"]/*'/>
    ImagePolicyEntryTypeUInt8,
    /// <include file='IMAGE_POLICY_ENTRY_TYPE.xml' path='doc/member[@name="IMAGE_POLICY_ENTRY_TYPE.ImagePolicyEntryTypeInt16"]/*'/>
    ImagePolicyEntryTypeInt16,
    /// <include file='IMAGE_POLICY_ENTRY_TYPE.xml' path='doc/member[@name="IMAGE_POLICY_ENTRY_TYPE.ImagePolicyEntryTypeUInt16"]/*'/>
    ImagePolicyEntryTypeUInt16,
    /// <include file='IMAGE_POLICY_ENTRY_TYPE.xml' path='doc/member[@name="IMAGE_POLICY_ENTRY_TYPE.ImagePolicyEntryTypeInt32"]/*'/>
    ImagePolicyEntryTypeInt32,
    /// <include file='IMAGE_POLICY_ENTRY_TYPE.xml' path='doc/member[@name="IMAGE_POLICY_ENTRY_TYPE.ImagePolicyEntryTypeUInt32"]/*'/>
    ImagePolicyEntryTypeUInt32,
    /// <include file='IMAGE_POLICY_ENTRY_TYPE.xml' path='doc/member[@name="IMAGE_POLICY_ENTRY_TYPE.ImagePolicyEntryTypeInt64"]/*'/>
    ImagePolicyEntryTypeInt64,
    /// <include file='IMAGE_POLICY_ENTRY_TYPE.xml' path='doc/member[@name="IMAGE_POLICY_ENTRY_TYPE.ImagePolicyEntryTypeUInt64"]/*'/>
    ImagePolicyEntryTypeUInt64,
    /// <include file='IMAGE_POLICY_ENTRY_TYPE.xml' path='doc/member[@name="IMAGE_POLICY_ENTRY_TYPE.ImagePolicyEntryTypeAnsiString"]/*'/>
    ImagePolicyEntryTypeAnsiString,
    /// <include file='IMAGE_POLICY_ENTRY_TYPE.xml' path='doc/member[@name="IMAGE_POLICY_ENTRY_TYPE.ImagePolicyEntryTypeUnicodeString"]/*'/>
    ImagePolicyEntryTypeUnicodeString,
    /// <include file='IMAGE_POLICY_ENTRY_TYPE.xml' path='doc/member[@name="IMAGE_POLICY_ENTRY_TYPE.ImagePolicyEntryTypeOverride"]/*'/>
    ImagePolicyEntryTypeOverride,
    /// <include file='IMAGE_POLICY_ENTRY_TYPE.xml' path='doc/member[@name="IMAGE_POLICY_ENTRY_TYPE.ImagePolicyEntryTypeMaximum"]/*'/>
    ImagePolicyEntryTypeMaximum,
}