// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/thumbcache.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WTS_FLAGS
{
    WTS_NONE = 0,
    WTS_EXTRACT = 0,
    WTS_INCACHEONLY = 0x1,
    WTS_FASTEXTRACT = 0x2,
    WTS_FORCEEXTRACTION = 0x4,
    WTS_SLOWRECLAIM = 0x8,
    WTS_EXTRACTDONOTCACHE = 0x20,
    WTS_SCALETOREQUESTEDSIZE = 0x40,
    WTS_SKIPFASTEXTRACT = 0x80,
    WTS_EXTRACTINPROC = 0x100,
    WTS_CROPTOSQUARE = 0x200,
    WTS_INSTANCESURROGATE = 0x400,
    WTS_REQUIRESURROGATE = 0x800,
    WTS_APPSTYLE = 0x2000,
    WTS_WIDETHUMBNAILS = 0x4000,
    WTS_IDEALCACHESIZEONLY = 0x8000,
    WTS_SCALEUP = 0x10000,
}
