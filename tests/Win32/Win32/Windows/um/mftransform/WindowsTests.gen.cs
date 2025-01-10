// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "Windows"/> class.</summary>
public static unsafe partial class WindowsTests
{
    /// <summary>Validates that the value of the <see cref = "MEDeviceStreamCreated"/> property is correct.</summary>

    [Test]
    public static void MEDeviceStreamCreatedTest()
    {
        Assert.That(
            MEDeviceStreamCreated,
            Is.EqualTo(
                new Guid(0x0252a1cf, 0x3540, 0x43b4, 0x91, 0x64, 0xd7, 0x2e, 0xb4, 0x05, 0xfa, 0x40)
            )
        );
    }
}
