// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum NSTCEHITTEST
{
    NSTCEHT_NOWHERE = 0x1,
    NSTCEHT_ONITEMICON = 0x2,
    NSTCEHT_ONITEMLABEL = 0x4,
    NSTCEHT_ONITEMINDENT = 0x8,
    NSTCEHT_ONITEMBUTTON = 0x10,
    NSTCEHT_ONITEMRIGHT = 0x20,
    NSTCEHT_ONITEMSTATEICON = 0x40,
    NSTCEHT_ONITEM = 0x46,
    NSTCEHT_ONITEMTABBUTTON = 0x1000,
}
