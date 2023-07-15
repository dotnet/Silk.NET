// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='UMS_THREAD_INFO_CLASS.xml' path='doc/member[@name="UMS_THREAD_INFO_CLASS"]/*'/>
public enum UMS_THREAD_INFO_CLASS
{
    /// <include file='UMS_THREAD_INFO_CLASS.xml' path='doc/member[@name="UMS_THREAD_INFO_CLASS.UmsThreadInvalidInfoClass"]/*'/>
    UmsThreadInvalidInfoClass = 0,
    /// <include file='UMS_THREAD_INFO_CLASS.xml' path='doc/member[@name="UMS_THREAD_INFO_CLASS.UmsThreadUserContext"]/*'/>
    UmsThreadUserContext,
    /// <include file='UMS_THREAD_INFO_CLASS.xml' path='doc/member[@name="UMS_THREAD_INFO_CLASS.UmsThreadPriority"]/*'/>
    UmsThreadPriority,
    /// <include file='UMS_THREAD_INFO_CLASS.xml' path='doc/member[@name="UMS_THREAD_INFO_CLASS.UmsThreadAffinity"]/*'/>
    UmsThreadAffinity,
    /// <include file='UMS_THREAD_INFO_CLASS.xml' path='doc/member[@name="UMS_THREAD_INFO_CLASS.UmsThreadTeb"]/*'/>
    UmsThreadTeb,
    /// <include file='UMS_THREAD_INFO_CLASS.xml' path='doc/member[@name="UMS_THREAD_INFO_CLASS.UmsThreadIsSuspended"]/*'/>
    UmsThreadIsSuspended,
    /// <include file='UMS_THREAD_INFO_CLASS.xml' path='doc/member[@name="UMS_THREAD_INFO_CLASS.UmsThreadIsTerminated"]/*'/>
    UmsThreadIsTerminated,
    /// <include file='UMS_THREAD_INFO_CLASS.xml' path='doc/member[@name="UMS_THREAD_INFO_CLASS.UmsThreadMaxInfoClass"]/*'/>
    UmsThreadMaxInfoClass,
}