// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propvarutil.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum DRAWPROGRESSFLAGS
{
    DPF_NONE = 0x0,
    DPF_MARQUEE = 0x1,
    DPF_MARQUEE_COMPLETE = 0x2,
    DPF_ERROR = 0x4,
    DPF_WARNING = 0x8,
    DPF_STOPPED = 0x10,
}
