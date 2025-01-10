// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public enum D2D1_SUBPROPERTY
{
    D2D1_SUBPROPERTY_DISPLAYNAME = unchecked((int)(0x80000000)),
    D2D1_SUBPROPERTY_ISREADONLY = unchecked((int)(0x80000001)),
    D2D1_SUBPROPERTY_MIN = unchecked((int)(0x80000002)),
    D2D1_SUBPROPERTY_MAX = unchecked((int)(0x80000003)),
    D2D1_SUBPROPERTY_DEFAULT = unchecked((int)(0x80000004)),
    D2D1_SUBPROPERTY_FIELDS = unchecked((int)(0x80000005)),
    D2D1_SUBPROPERTY_INDEX = unchecked((int)(0x80000006)),
    D2D1_SUBPROPERTY_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
