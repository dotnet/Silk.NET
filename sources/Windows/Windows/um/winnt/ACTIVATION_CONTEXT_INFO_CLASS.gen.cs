// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='ACTIVATION_CONTEXT_INFO_CLASS.xml' path='doc/member[@name="ACTIVATION_CONTEXT_INFO_CLASS"]/*' />
public enum ACTIVATION_CONTEXT_INFO_CLASS
{
    /// <include file='ACTIVATION_CONTEXT_INFO_CLASS.xml' path='doc/member[@name="ACTIVATION_CONTEXT_INFO_CLASS.ActivationContextBasicInformation"]/*' />
    ActivationContextBasicInformation = 1,

    /// <include file='ACTIVATION_CONTEXT_INFO_CLASS.xml' path='doc/member[@name="ACTIVATION_CONTEXT_INFO_CLASS.ActivationContextDetailedInformation"]/*' />
    ActivationContextDetailedInformation = 2,

    /// <include file='ACTIVATION_CONTEXT_INFO_CLASS.xml' path='doc/member[@name="ACTIVATION_CONTEXT_INFO_CLASS.AssemblyDetailedInformationInActivationContext"]/*' />
    AssemblyDetailedInformationInActivationContext = 3,

    /// <include file='ACTIVATION_CONTEXT_INFO_CLASS.xml' path='doc/member[@name="ACTIVATION_CONTEXT_INFO_CLASS.FileInformationInAssemblyOfAssemblyInActivationContext"]/*' />
    FileInformationInAssemblyOfAssemblyInActivationContext = 4,

    /// <include file='ACTIVATION_CONTEXT_INFO_CLASS.xml' path='doc/member[@name="ACTIVATION_CONTEXT_INFO_CLASS.RunlevelInformationInActivationContext"]/*' />
    RunlevelInformationInActivationContext = 5,

    /// <include file='ACTIVATION_CONTEXT_INFO_CLASS.xml' path='doc/member[@name="ACTIVATION_CONTEXT_INFO_CLASS.CompatibilityInformationInActivationContext"]/*' />
    CompatibilityInformationInActivationContext = 6,

    /// <include file='ACTIVATION_CONTEXT_INFO_CLASS.xml' path='doc/member[@name="ACTIVATION_CONTEXT_INFO_CLASS.ActivationContextManifestResourceName"]/*' />
    ActivationContextManifestResourceName = 7,

    /// <include file='ACTIVATION_CONTEXT_INFO_CLASS.xml' path='doc/member[@name="ACTIVATION_CONTEXT_INFO_CLASS.MaxActivationContextInfoClass"]/*' />
    MaxActivationContextInfoClass,

    /// <include file='ACTIVATION_CONTEXT_INFO_CLASS.xml' path='doc/member[@name="ACTIVATION_CONTEXT_INFO_CLASS.AssemblyDetailedInformationInActivationContxt"]/*' />
    AssemblyDetailedInformationInActivationContxt = 3,

    /// <include file='ACTIVATION_CONTEXT_INFO_CLASS.xml' path='doc/member[@name="ACTIVATION_CONTEXT_INFO_CLASS.FileInformationInAssemblyOfAssemblyInActivationContxt"]/*' />
    FileInformationInAssemblyOfAssemblyInActivationContxt = 4,
}
