// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SPLEXICONTYPE
{
    eLEXTYPE_USER = (1 << 0),
    eLEXTYPE_APP = (1 << 1),
    eLEXTYPE_VENDORLEXICON = (1 << 2),
    eLEXTYPE_LETTERTOSOUND = (1 << 3),
    eLEXTYPE_MORPHOLOGY = (1 << 4),
    eLEXTYPE_RESERVED4 = (1 << 5),
    eLEXTYPE_USER_SHORTCUT = (1 << 6),
    eLEXTYPE_RESERVED6 = (1 << 7),
    eLEXTYPE_RESERVED7 = (1 << 8),
    eLEXTYPE_RESERVED8 = (1 << 9),
    eLEXTYPE_RESERVED9 = (1 << 10),
    eLEXTYPE_RESERVED10 = (1 << 11),
    eLEXTYPE_PRIVATE1 = (1 << 12),
    eLEXTYPE_PRIVATE2 = (1 << 13),
    eLEXTYPE_PRIVATE3 = (1 << 14),
    eLEXTYPE_PRIVATE4 = (1 << 15),
    eLEXTYPE_PRIVATE5 = (1 << 16),
    eLEXTYPE_PRIVATE6 = (1 << 17),
    eLEXTYPE_PRIVATE7 = (1 << 18),
    eLEXTYPE_PRIVATE8 = (1 << 19),
    eLEXTYPE_PRIVATE9 = (1 << 20),
    eLEXTYPE_PRIVATE10 = (1 << 21),
    eLEXTYPE_PRIVATE11 = (1 << 22),
    eLEXTYPE_PRIVATE12 = (1 << 23),
    eLEXTYPE_PRIVATE13 = (1 << 24),
    eLEXTYPE_PRIVATE14 = (1 << 25),
    eLEXTYPE_PRIVATE15 = (1 << 26),
    eLEXTYPE_PRIVATE16 = (1 << 27),
    eLEXTYPE_PRIVATE17 = (1 << 28),
    eLEXTYPE_PRIVATE18 = (1 << 29),
    eLEXTYPE_PRIVATE19 = (1 << 30),
    eLEXTYPE_PRIVATE20 = (1 << 31),
}
