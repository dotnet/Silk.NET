// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='AppPolicyThreadInitializationType.xml' path='doc/member[@name="AppPolicyThreadInitializationType"]/*' />
public enum AppPolicyThreadInitializationType
{
    /// <include file='AppPolicyThreadInitializationType.xml' path='doc/member[@name="AppPolicyThreadInitializationType.AppPolicyThreadInitializationType_None"]/*' />
    AppPolicyThreadInitializationType_None = 0,

    /// <include file='AppPolicyThreadInitializationType.xml' path='doc/member[@name="AppPolicyThreadInitializationType.AppPolicyThreadInitializationType_InitializeWinRT"]/*' />
    AppPolicyThreadInitializationType_InitializeWinRT = 1,
}
