// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WindowsStorageCOM.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.WinRT;

/// <include file='CreateProcessMethod.xml' path='doc/member[@name="CreateProcessMethod"]/*' />
public enum CreateProcessMethod
{
    /// <include file='CreateProcessMethod.xml' path='doc/member[@name="CreateProcessMethod.CpCreateProcess"]/*' />
    CpCreateProcess = 0,

    /// <include file='CreateProcessMethod.xml' path='doc/member[@name="CreateProcessMethod.CpCreateProcessAsUser"]/*' />
    CpCreateProcessAsUser = 1,

    /// <include file='CreateProcessMethod.xml' path='doc/member[@name="CreateProcessMethod.CpAicLaunchAdminProcess"]/*' />
    CpAicLaunchAdminProcess = 2,
}
