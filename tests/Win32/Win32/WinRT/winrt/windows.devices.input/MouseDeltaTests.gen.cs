// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "MouseDelta"/> struct.</summary>
public static unsafe partial class MouseDeltaTests
{
    /// <summary>Validates that the <see cref = "MouseDelta"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MouseDelta>(), Is.EqualTo(sizeof(MouseDelta)));
    }

    /// <summary>Validates that the <see cref = "MouseDelta"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MouseDelta).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MouseDelta"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MouseDelta), Is.EqualTo(8));
    }
}
