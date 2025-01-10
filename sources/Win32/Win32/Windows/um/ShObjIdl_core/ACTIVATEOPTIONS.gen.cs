// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum ACTIVATEOPTIONS
{
    AO_NONE = 0,
    AO_DESIGNMODE = 0x1,
    AO_NOERRORUI = 0x2,
    AO_NOSPLASHSCREEN = 0x4,
    AO_PRELAUNCH = 0x2000000,
}
