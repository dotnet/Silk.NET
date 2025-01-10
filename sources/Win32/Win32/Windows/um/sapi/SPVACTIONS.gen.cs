// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SPVACTIONS
{
    SPVA_Speak = 0,
    SPVA_Silence = (SPVA_Speak + 1),
    SPVA_Pronounce = (SPVA_Silence + 1),
    SPVA_Bookmark = (SPVA_Pronounce + 1),
    SPVA_SpellOut = (SPVA_Bookmark + 1),
    SPVA_Section = (SPVA_SpellOut + 1),
    SPVA_ParseUnknownTag = (SPVA_Section + 1),
}
