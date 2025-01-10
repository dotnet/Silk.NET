// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WS_POLICY_PROPERTY_ID
{
    WS_POLICY_PROPERTY_STATE = 1,
    WS_POLICY_PROPERTY_MAX_ALTERNATIVES = 2,
    WS_POLICY_PROPERTY_MAX_DEPTH = 3,
    WS_POLICY_PROPERTY_MAX_EXTENSIONS = 4,
}
