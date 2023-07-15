// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/processthreadsapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='THREAD_INFORMATION_CLASS.xml' path='doc/member[@name="THREAD_INFORMATION_CLASS"]/*'/>
public enum THREAD_INFORMATION_CLASS
{
    /// <include file='THREAD_INFORMATION_CLASS.xml' path='doc/member[@name="THREAD_INFORMATION_CLASS.ThreadMemoryPriority"]/*'/>
    ThreadMemoryPriority,
    /// <include file='THREAD_INFORMATION_CLASS.xml' path='doc/member[@name="THREAD_INFORMATION_CLASS.ThreadAbsoluteCpuPriority"]/*'/>
    ThreadAbsoluteCpuPriority,
    /// <include file='THREAD_INFORMATION_CLASS.xml' path='doc/member[@name="THREAD_INFORMATION_CLASS.ThreadDynamicCodePolicy"]/*'/>
    ThreadDynamicCodePolicy,
    /// <include file='THREAD_INFORMATION_CLASS.xml' path='doc/member[@name="THREAD_INFORMATION_CLASS.ThreadPowerThrottling"]/*'/>
    ThreadPowerThrottling,
    /// <include file='THREAD_INFORMATION_CLASS.xml' path='doc/member[@name="THREAD_INFORMATION_CLASS.ThreadInformationClassMax"]/*'/>
    ThreadInformationClassMax,
}