// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/manipulations.h and um/manipulations_i.c in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum MANIPULATION_PROCESSOR_MANIPULATIONS
{
    MANIPULATION_NONE = 0,
    MANIPULATION_TRANSLATE_X = 0x1,
    MANIPULATION_TRANSLATE_Y = 0x2,
    MANIPULATION_SCALE = 0x4,
    MANIPULATION_ROTATE = 0x8,
    MANIPULATION_ALL = 0xf,
}
