// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='ACL_INFORMATION_CLASS.xml' path='doc/member[@name="ACL_INFORMATION_CLASS"]/*'/>
public enum ACL_INFORMATION_CLASS
{
    /// <include file='ACL_INFORMATION_CLASS.xml' path='doc/member[@name="ACL_INFORMATION_CLASS.AclRevisionInformation"]/*'/>
    AclRevisionInformation = 1,
    /// <include file='ACL_INFORMATION_CLASS.xml' path='doc/member[@name="ACL_INFORMATION_CLASS.AclSizeInformation"]/*'/>
    AclSizeInformation,
}