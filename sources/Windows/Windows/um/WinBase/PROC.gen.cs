// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.Windows.PROC_THREAD_ATTRIBUTE_NUM;

namespace Silk.NET.Windows;
public static partial class PROC
{
    [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_NUMBER 0x0000FFFF")]
    public const int PROC_THREAD_ATTRIBUTE_NUMBER = 0x0000FFFF;
    [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_THREAD 0x00010000")]
    public const int PROC_THREAD_ATTRIBUTE_THREAD = 0x00010000;
    [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_INPUT 0x00020000")]
    public const int PROC_THREAD_ATTRIBUTE_INPUT = 0x00020000;
    [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_ADDITIVE 0x00040000")]
    public const int PROC_THREAD_ATTRIBUTE_ADDITIVE = 0x00040000;
    [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_PARENT_PROCESS ProcThreadAttributeValue (ProcThreadAttributeParentProcess, FALSE, TRUE, FALSE)")]
    public const int PROC_THREAD_ATTRIBUTE_PARENT_PROCESS = (((int)(ProcThreadAttributeParentProcess) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));
    [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_HANDLE_LIST ProcThreadAttributeValue (ProcThreadAttributeHandleList, FALSE, TRUE, FALSE)")]
    public const int PROC_THREAD_ATTRIBUTE_HANDLE_LIST = (((int)(ProcThreadAttributeHandleList) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));
    [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_GROUP_AFFINITY ProcThreadAttributeValue (ProcThreadAttributeGroupAffinity, TRUE, TRUE, FALSE)")]
    public const int PROC_THREAD_ATTRIBUTE_GROUP_AFFINITY = (((int)(ProcThreadAttributeGroupAffinity) & 0x0000FFFF) | ((1 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));
    [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_PREFERRED_NODE ProcThreadAttributeValue (ProcThreadAttributePreferredNode, FALSE, TRUE, FALSE)")]
    public const int PROC_THREAD_ATTRIBUTE_PREFERRED_NODE = (((int)(ProcThreadAttributePreferredNode) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));
    [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_IDEAL_PROCESSOR ProcThreadAttributeValue (ProcThreadAttributeIdealProcessor, TRUE, TRUE, FALSE)")]
    public const int PROC_THREAD_ATTRIBUTE_IDEAL_PROCESSOR = (((int)(ProcThreadAttributeIdealProcessor) & 0x0000FFFF) | ((1 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));
    [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_UMS_THREAD ProcThreadAttributeValue (ProcThreadAttributeUmsThread, TRUE, TRUE, FALSE)")]
    public const int PROC_THREAD_ATTRIBUTE_UMS_THREAD = (((int)(ProcThreadAttributeUmsThread) & 0x0000FFFF) | ((1 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));
    [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_MITIGATION_POLICY ProcThreadAttributeValue (ProcThreadAttributeMitigationPolicy, FALSE, TRUE, FALSE)")]
    public const int PROC_THREAD_ATTRIBUTE_MITIGATION_POLICY = (((int)(ProcThreadAttributeMitigationPolicy) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));
    [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_SECURITY_CAPABILITIES ProcThreadAttributeValue (ProcThreadAttributeSecurityCapabilities, FALSE, TRUE, FALSE)")]
    public const int PROC_THREAD_ATTRIBUTE_SECURITY_CAPABILITIES = (((int)(ProcThreadAttributeSecurityCapabilities) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));
    [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_PROTECTION_LEVEL ProcThreadAttributeValue (ProcThreadAttributeProtectionLevel, FALSE, TRUE, FALSE)")]
    public const int PROC_THREAD_ATTRIBUTE_PROTECTION_LEVEL = (((int)(ProcThreadAttributeProtectionLevel) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));
    [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_PSEUDOCONSOLE ProcThreadAttributeValue (ProcThreadAttributePseudoConsole, FALSE, TRUE, FALSE)")]
    public const int PROC_THREAD_ATTRIBUTE_PSEUDOCONSOLE = (((int)(ProcThreadAttributePseudoConsole) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));
    [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_MACHINE_TYPE ProcThreadAttributeValue (ProcThreadAttributeMachineType, FALSE, TRUE, FALSE)")]
    public const int PROC_THREAD_ATTRIBUTE_MACHINE_TYPE = (((int)(ProcThreadAttributeMachineType) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));
    [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_ENABLE_OPTIONAL_XSTATE_FEATURES ProcThreadAttributeValue (ProcThreadAttributeEnableOptionalXStateFeatures, TRUE, TRUE, FALSE)")]
    public const int PROC_THREAD_ATTRIBUTE_ENABLE_OPTIONAL_XSTATE_FEATURES = (((int)(ProcThreadAttributeEnableOptionalXStateFeatures) & 0x0000FFFF) | ((1 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));
    [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_JOB_LIST ProcThreadAttributeValue (ProcThreadAttributeJobList, FALSE, TRUE, FALSE)")]
    public const int PROC_THREAD_ATTRIBUTE_JOB_LIST = (((int)(ProcThreadAttributeJobList) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));
    [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_CHILD_PROCESS_POLICY ProcThreadAttributeValue (ProcThreadAttributeChildProcessPolicy, FALSE, TRUE, FALSE)")]
    public const int PROC_THREAD_ATTRIBUTE_CHILD_PROCESS_POLICY = (((int)(ProcThreadAttributeChildProcessPolicy) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));
    [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_ALL_APPLICATION_PACKAGES_POLICY ProcThreadAttributeValue (ProcThreadAttributeAllApplicationPackagesPolicy, FALSE, TRUE, FALSE)")]
    public const int PROC_THREAD_ATTRIBUTE_ALL_APPLICATION_PACKAGES_POLICY = (((int)(ProcThreadAttributeAllApplicationPackagesPolicy) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));
    [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_WIN32K_FILTER ProcThreadAttributeValue (ProcThreadAttributeWin32kFilter, FALSE, TRUE, FALSE)")]
    public const int PROC_THREAD_ATTRIBUTE_WIN32K_FILTER = (((int)(ProcThreadAttributeWin32kFilter) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));
    [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_DESKTOP_APP_POLICY ProcThreadAttributeValue (ProcThreadAttributeDesktopAppPolicy, FALSE, TRUE, FALSE)")]
    public const int PROC_THREAD_ATTRIBUTE_DESKTOP_APP_POLICY = (((int)(ProcThreadAttributeDesktopAppPolicy) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));
    [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_MITIGATION_AUDIT_POLICY ProcThreadAttributeValue (ProcThreadAttributeMitigationAuditPolicy, FALSE, TRUE, FALSE)")]
    public const int PROC_THREAD_ATTRIBUTE_MITIGATION_AUDIT_POLICY = (((int)(ProcThreadAttributeMitigationAuditPolicy) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));
    [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_COMPONENT_FILTER ProcThreadAttributeValue (ProcThreadAttributeComponentFilter, FALSE, TRUE, FALSE)")]
    public const int PROC_THREAD_ATTRIBUTE_COMPONENT_FILTER = (((int)(ProcThreadAttributeComponentFilter) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));
    [NativeTypeName("#define PROC_THREAD_ATTRIBUTE_TRUSTED_APP ProcThreadAttributeValue (ProcThreadAttributeTrustedApp, FALSE, TRUE, FALSE)")]
    public const int PROC_THREAD_ATTRIBUTE_TRUSTED_APP = (((int)(ProcThreadAttributeTrustedApp) & 0x0000FFFF) | ((0 != 0) ? 0x00010000 : 0) | ((1 != 0) ? 0x00020000 : 0) | ((0 != 0) ? 0x00040000 : 0));
}