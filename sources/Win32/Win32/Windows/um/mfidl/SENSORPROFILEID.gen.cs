// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows10.0.16299.0")]
public partial struct SENSORPROFILEID
{
    public Guid Type;

    [NativeTypeName("UINT32")]
    public uint Index;

    [NativeTypeName("UINT32")]
    public uint Unused;
}
