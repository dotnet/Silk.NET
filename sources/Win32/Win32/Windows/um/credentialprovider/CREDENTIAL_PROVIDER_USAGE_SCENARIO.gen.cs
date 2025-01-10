// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum CREDENTIAL_PROVIDER_USAGE_SCENARIO
{
    CPUS_INVALID = 0,
    CPUS_LOGON = (CPUS_INVALID + 1),
    CPUS_UNLOCK_WORKSTATION = (CPUS_LOGON + 1),
    CPUS_CHANGE_PASSWORD = (CPUS_UNLOCK_WORKSTATION + 1),
    CPUS_CREDUI = (CPUS_CHANGE_PASSWORD + 1),
    CPUS_PLAP = (CPUS_CREDUI + 1),
}
