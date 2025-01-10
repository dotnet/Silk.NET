// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum STGOP
{
    STGOP_MOVE = 1,
    STGOP_COPY = 2,
    STGOP_SYNC = 3,
    STGOP_REMOVE = 5,
    STGOP_RENAME = 6,
    STGOP_APPLYPROPERTIES = 8,
    STGOP_NEW = 10,
}
