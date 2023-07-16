// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='ENLISTMENT_INFORMATION_CLASS.xml' path='doc/member[@name="ENLISTMENT_INFORMATION_CLASS"]/*'/>
public enum ENLISTMENT_INFORMATION_CLASS
{
    /// <include file='ENLISTMENT_INFORMATION_CLASS.xml' path='doc/member[@name="ENLISTMENT_INFORMATION_CLASS.EnlistmentBasicInformation"]/*'/>
    EnlistmentBasicInformation,
    /// <include file='ENLISTMENT_INFORMATION_CLASS.xml' path='doc/member[@name="ENLISTMENT_INFORMATION_CLASS.EnlistmentRecoveryInformation"]/*'/>
    EnlistmentRecoveryInformation,
    /// <include file='ENLISTMENT_INFORMATION_CLASS.xml' path='doc/member[@name="ENLISTMENT_INFORMATION_CLASS.EnlistmentCrmInformation"]/*'/>
    EnlistmentCrmInformation,
}