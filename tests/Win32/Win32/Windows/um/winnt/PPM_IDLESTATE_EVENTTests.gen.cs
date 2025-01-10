// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "PPM_IDLESTATE_EVENT"/> struct.</summary>
public static unsafe partial class PPM_IDLESTATE_EVENTTests
{
    /// <summary>Validates that the <see cref = "PPM_IDLESTATE_EVENT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PPM_IDLESTATE_EVENT>(), Is.EqualTo(sizeof(PPM_IDLESTATE_EVENT)));
    }

    /// <summary>Validates that the <see cref = "PPM_IDLESTATE_EVENT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PPM_IDLESTATE_EVENT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PPM_IDLESTATE_EVENT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(PPM_IDLESTATE_EVENT), Is.EqualTo(16));
    }
}
