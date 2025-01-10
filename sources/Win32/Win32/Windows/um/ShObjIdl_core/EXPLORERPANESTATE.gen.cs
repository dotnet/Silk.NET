// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum EXPLORERPANESTATE
{
    EPS_DONTCARE = 0,
    EPS_DEFAULT_ON = 0x1,
    EPS_DEFAULT_OFF = 0x2,
    EPS_STATEMASK = 0xffff,
    EPS_INITIALSTATE = 0x10000,
    EPS_FORCE = 0x20000,
}
