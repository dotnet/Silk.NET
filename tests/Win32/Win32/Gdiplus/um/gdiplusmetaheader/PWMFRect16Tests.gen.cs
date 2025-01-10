// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusmetaheader.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus.UnitTests;

/// <summary>Provides validation of the <see cref = "PWMFRect16"/> struct.</summary>
public static unsafe partial class PWMFRect16Tests
{
    /// <summary>Validates that the <see cref = "PWMFRect16"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PWMFRect16>(), Is.EqualTo(sizeof(PWMFRect16)));
    }

    /// <summary>Validates that the <see cref = "PWMFRect16"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PWMFRect16).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PWMFRect16"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(PWMFRect16), Is.EqualTo(8));
    }
}
