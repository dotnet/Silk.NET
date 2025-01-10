// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WBEM_LIMITATION_FLAG_TYPE
{
    WBEM_FLAG_EXCLUDE_OBJECT_QUALIFIERS = 0x10,
    WBEM_FLAG_EXCLUDE_PROPERTY_QUALIFIERS = 0x20,
}
