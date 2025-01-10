// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum PROPDESC_TYPE_FLAGS
{
    PDTF_DEFAULT = 0,
    PDTF_MULTIPLEVALUES = 0x1,
    PDTF_ISINNATE = 0x2,
    PDTF_ISGROUP = 0x4,
    PDTF_CANGROUPBY = 0x8,
    PDTF_CANSTACKBY = 0x10,
    PDTF_ISTREEPROPERTY = 0x20,
    PDTF_INCLUDEINFULLTEXTQUERY = 0x40,
    PDTF_ISVIEWABLE = 0x80,
    PDTF_ISQUERYABLE = 0x100,
    PDTF_CANBEPURGED = 0x200,
    PDTF_SEARCHRAWVALUE = 0x400,
    PDTF_DONTCOERCEEMPTYSTRINGS = 0x800,
    PDTF_ALWAYSINSUPPLEMENTALSTORE = 0x1000,
    PDTF_ISSYSTEMPROPERTY = unchecked((int)(0x80000000)),
    PDTF_MASK_ALL = unchecked((int)(0x80001fff)),
}
