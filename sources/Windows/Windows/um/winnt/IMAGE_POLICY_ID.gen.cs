// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IMAGE_POLICY_ID.xml' path='doc/member[@name="IMAGE_POLICY_ID"]/*' />
public enum IMAGE_POLICY_ID
{
    /// <include file='IMAGE_POLICY_ID.xml' path='doc/member[@name="IMAGE_POLICY_ID.ImagePolicyIdNone"]/*' />
    ImagePolicyIdNone = 0,

    /// <include file='IMAGE_POLICY_ID.xml' path='doc/member[@name="IMAGE_POLICY_ID.ImagePolicyIdEtw"]/*' />
    ImagePolicyIdEtw,

    /// <include file='IMAGE_POLICY_ID.xml' path='doc/member[@name="IMAGE_POLICY_ID.ImagePolicyIdDebug"]/*' />
    ImagePolicyIdDebug,

    /// <include file='IMAGE_POLICY_ID.xml' path='doc/member[@name="IMAGE_POLICY_ID.ImagePolicyIdCrashDump"]/*' />
    ImagePolicyIdCrashDump,

    /// <include file='IMAGE_POLICY_ID.xml' path='doc/member[@name="IMAGE_POLICY_ID.ImagePolicyIdCrashDumpKey"]/*' />
    ImagePolicyIdCrashDumpKey,

    /// <include file='IMAGE_POLICY_ID.xml' path='doc/member[@name="IMAGE_POLICY_ID.ImagePolicyIdCrashDumpKeyGuid"]/*' />
    ImagePolicyIdCrashDumpKeyGuid,

    /// <include file='IMAGE_POLICY_ID.xml' path='doc/member[@name="IMAGE_POLICY_ID.ImagePolicyIdParentSd"]/*' />
    ImagePolicyIdParentSd,

    /// <include file='IMAGE_POLICY_ID.xml' path='doc/member[@name="IMAGE_POLICY_ID.ImagePolicyIdParentSdRev"]/*' />
    ImagePolicyIdParentSdRev,

    /// <include file='IMAGE_POLICY_ID.xml' path='doc/member[@name="IMAGE_POLICY_ID.ImagePolicyIdSvn"]/*' />
    ImagePolicyIdSvn,

    /// <include file='IMAGE_POLICY_ID.xml' path='doc/member[@name="IMAGE_POLICY_ID.ImagePolicyIdDeviceId"]/*' />
    ImagePolicyIdDeviceId,

    /// <include file='IMAGE_POLICY_ID.xml' path='doc/member[@name="IMAGE_POLICY_ID.ImagePolicyIdCapability"]/*' />
    ImagePolicyIdCapability,

    /// <include file='IMAGE_POLICY_ID.xml' path='doc/member[@name="IMAGE_POLICY_ID.ImagePolicyIdScenarioId"]/*' />
    ImagePolicyIdScenarioId,

    /// <include file='IMAGE_POLICY_ID.xml' path='doc/member[@name="IMAGE_POLICY_ID.ImagePolicyIdMaximum"]/*' />
    ImagePolicyIdMaximum,
}
