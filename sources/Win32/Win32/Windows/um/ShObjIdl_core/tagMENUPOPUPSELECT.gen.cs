// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum tagMENUPOPUPSELECT
{
    MPOS_EXECUTE = 0,
    MPOS_FULLCANCEL = (MPOS_EXECUTE + 1),
    MPOS_CANCELLEVEL = (MPOS_FULLCANCEL + 1),
    MPOS_SELECTLEFT = (MPOS_CANCELLEVEL + 1),
    MPOS_SELECTRIGHT = (MPOS_SELECTLEFT + 1),
    MPOS_CHILDTRACKING = (MPOS_SELECTRIGHT + 1),
}
