// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum CIMTYPE_ENUMERATION
{
    CIM_ILLEGAL = 0xfff,
    CIM_EMPTY = 0,
    CIM_SINT8 = 16,
    CIM_UINT8 = 17,
    CIM_SINT16 = 2,
    CIM_UINT16 = 18,
    CIM_SINT32 = 3,
    CIM_UINT32 = 19,
    CIM_SINT64 = 20,
    CIM_UINT64 = 21,
    CIM_REAL32 = 4,
    CIM_REAL64 = 5,
    CIM_BOOLEAN = 11,
    CIM_STRING = 8,
    CIM_DATETIME = 101,
    CIM_REFERENCE = 102,
    CIM_CHAR16 = 103,
    CIM_OBJECT = 13,
    CIM_FLAG_ARRAY = 0x2000,
}
