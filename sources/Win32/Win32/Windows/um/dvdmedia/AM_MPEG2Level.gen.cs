// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum AM_MPEG2Level
{
    AM_MPEG2Level_Low = 1,
    AM_MPEG2Level_Main = 2,
    AM_MPEG2Level_High1440 = 3,
    AM_MPEG2Level_High = 4,
}
