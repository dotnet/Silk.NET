// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum PROPBAG2_TYPE
{
    PROPBAG2_TYPE_UNDEFINED = 0,
    PROPBAG2_TYPE_DATA = 1,
    PROPBAG2_TYPE_URL = 2,
    PROPBAG2_TYPE_OBJECT = 3,
    PROPBAG2_TYPE_STREAM = 4,
    PROPBAG2_TYPE_STORAGE = 5,
    PROPBAG2_TYPE_MONIKER = 6,
}
