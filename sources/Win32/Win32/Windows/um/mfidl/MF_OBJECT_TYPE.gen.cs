// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum MF_OBJECT_TYPE
{
    MF_OBJECT_MEDIASOURCE = 0,
    MF_OBJECT_BYTESTREAM = (MF_OBJECT_MEDIASOURCE + 1),
    MF_OBJECT_INVALID = (MF_OBJECT_BYTESTREAM + 1),
}
