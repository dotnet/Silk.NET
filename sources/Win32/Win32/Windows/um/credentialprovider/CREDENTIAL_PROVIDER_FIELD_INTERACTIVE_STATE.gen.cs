// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum CREDENTIAL_PROVIDER_FIELD_INTERACTIVE_STATE
{
    CPFIS_NONE = 0,
    CPFIS_READONLY = (CPFIS_NONE + 1),
    CPFIS_DISABLED = (CPFIS_READONLY + 1),
    CPFIS_FOCUSED = (CPFIS_DISABLED + 1),
}
