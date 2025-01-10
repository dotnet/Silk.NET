// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SHCONTF
{
    SHCONTF_CHECKING_FOR_CHILDREN = 0x10,
    SHCONTF_FOLDERS = 0x20,
    SHCONTF_NONFOLDERS = 0x40,
    SHCONTF_INCLUDEHIDDEN = 0x80,
    SHCONTF_INIT_ON_FIRST_NEXT = 0x100,
    SHCONTF_NETPRINTERSRCH = 0x200,
    SHCONTF_SHAREABLE = 0x400,
    SHCONTF_STORAGE = 0x800,
    SHCONTF_NAVIGATION_ENUM = 0x1000,
    SHCONTF_FASTITEMS = 0x2000,
    SHCONTF_FLATLIST = 0x4000,
    SHCONTF_ENABLE_ASYNC = 0x8000,
    SHCONTF_INCLUDESUPERHIDDEN = 0x10000,
}
