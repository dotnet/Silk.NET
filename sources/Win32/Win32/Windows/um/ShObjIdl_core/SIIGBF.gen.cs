// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SIIGBF
{
    SIIGBF_RESIZETOFIT = 0,
    SIIGBF_BIGGERSIZEOK = 0x1,
    SIIGBF_MEMORYONLY = 0x2,
    SIIGBF_ICONONLY = 0x4,
    SIIGBF_THUMBNAILONLY = 0x8,
    SIIGBF_INCACHEONLY = 0x10,
    SIIGBF_CROPTOSQUARE = 0x20,
    SIIGBF_WIDETHUMBNAILS = 0x40,
    SIIGBF_ICONBACKGROUND = 0x80,
    SIIGBF_SCALEUP = 0x100,
}
