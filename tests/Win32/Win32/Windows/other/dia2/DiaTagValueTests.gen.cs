// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "DiaTagValue"/> struct.</summary>
public static unsafe partial class DiaTagValueTests
{
    /// <summary>Validates that the <see cref = "DiaTagValue"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DiaTagValue>(), Is.EqualTo(sizeof(DiaTagValue)));
    }

    /// <summary>Validates that the <see cref = "DiaTagValue"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DiaTagValue).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DiaTagValue"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DiaTagValue), Is.EqualTo(17));
    }
}
