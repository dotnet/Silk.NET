// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum PI_FLAGS
{
    PI_PARSE_URL = 0x1,
    PI_FILTER_MODE = 0x2,
    PI_FORCE_ASYNC = 0x4,
    PI_USE_WORKERTHREAD = 0x8,
    PI_MIMEVERIFICATION = 0x10,
    PI_CLSIDLOOKUP = 0x20,
    PI_DATAPROGRESS = 0x40,
    PI_SYNCHRONOUS = 0x80,
    PI_APARTMENTTHREADED = 0x100,
    PI_CLASSINSTALL = 0x200,
    PI_PASSONBINDCTX = 0x2000,
    PI_NOMIMEHANDLER = 0x8000,
    PI_LOADAPPDIRECT = 0x4000,
    PD_FORCE_SWITCH = 0x10000,
    PI_PREFERDEFAULTHANDLER = 0x20000,
}
