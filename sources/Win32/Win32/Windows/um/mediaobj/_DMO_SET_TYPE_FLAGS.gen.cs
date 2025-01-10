// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mediaobj.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum _DMO_SET_TYPE_FLAGS
{
    DMO_SET_TYPEF_TEST_ONLY = 0x1,
    DMO_SET_TYPEF_CLEAR = 0x2,
}
