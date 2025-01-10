// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Flags]
public enum DML_CREATE_DEVICE_FLAGS
{
    DML_CREATE_DEVICE_FLAG_NONE = 0,
    DML_CREATE_DEVICE_FLAG_DEBUG = 0x1,
}
