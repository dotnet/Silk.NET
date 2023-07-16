// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MSV1_0_PROFILE_BUFFER_TYPE.xml' path='doc/member[@name="MSV1_0_PROFILE_BUFFER_TYPE"]/*'/>
public enum MSV1_0_PROFILE_BUFFER_TYPE
{
    /// <include file='MSV1_0_PROFILE_BUFFER_TYPE.xml' path='doc/member[@name="MSV1_0_PROFILE_BUFFER_TYPE.MsV1_0InteractiveProfile"]/*'/>
    MsV1_0InteractiveProfile = 2,
    /// <include file='MSV1_0_PROFILE_BUFFER_TYPE.xml' path='doc/member[@name="MSV1_0_PROFILE_BUFFER_TYPE.MsV1_0Lm20LogonProfile"]/*'/>
    MsV1_0Lm20LogonProfile,
    /// <include file='MSV1_0_PROFILE_BUFFER_TYPE.xml' path='doc/member[@name="MSV1_0_PROFILE_BUFFER_TYPE.MsV1_0SmartCardProfile"]/*'/>
    MsV1_0SmartCardProfile,
}