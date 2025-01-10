// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum KF_DEFINITION_FLAGS
{
    KFDF_LOCAL_REDIRECT_ONLY = 0x2,
    KFDF_ROAMABLE = 0x4,
    KFDF_PRECREATE = 0x8,
    KFDF_STREAM = 0x10,
    KFDF_PUBLISHEXPANDEDPATH = 0x20,
    KFDF_NO_REDIRECT_UI = 0x40,
}
