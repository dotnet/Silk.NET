// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum MF_CUSTOM_DECODE_UNIT_TYPE
{
    MF_DECODE_UNIT_NAL = 0,
    MF_DECODE_UNIT_SEI = 1,
}
