// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shappmgr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum APPINFODATAFLAGS
{
    AIM_DISPLAYNAME = 0x1,
    AIM_VERSION = 0x2,
    AIM_PUBLISHER = 0x4,
    AIM_PRODUCTID = 0x8,
    AIM_REGISTEREDOWNER = 0x10,
    AIM_REGISTEREDCOMPANY = 0x20,
    AIM_LANGUAGE = 0x40,
    AIM_SUPPORTURL = 0x80,
    AIM_SUPPORTTELEPHONE = 0x100,
    AIM_HELPLINK = 0x200,
    AIM_INSTALLLOCATION = 0x400,
    AIM_INSTALLSOURCE = 0x800,
    AIM_INSTALLDATE = 0x1000,
    AIM_CONTACT = 0x4000,
    AIM_COMMENTS = 0x8000,
    AIM_IMAGE = 0x20000,
    AIM_READMEURL = 0x40000,
    AIM_UPDATEINFOURL = 0x80000,
}
