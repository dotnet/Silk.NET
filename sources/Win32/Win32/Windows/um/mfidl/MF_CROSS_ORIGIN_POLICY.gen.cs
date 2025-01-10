// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum MF_CROSS_ORIGIN_POLICY
{
    MF_CROSS_ORIGIN_POLICY_NONE = 0,
    MF_CROSS_ORIGIN_POLICY_ANONYMOUS = 1,
    MF_CROSS_ORIGIN_POLICY_USE_CREDENTIALS = 2,
}
