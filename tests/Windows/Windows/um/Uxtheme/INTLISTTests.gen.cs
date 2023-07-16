// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "INTLIST"/> struct.</summary>
public static unsafe partial class INTLISTTests
{
    /// <summary>Validates that the <see cref = "INTLIST"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<INTLIST>(), Is.EqualTo(sizeof(INTLIST)));
    }

    /// <summary>Validates that the <see cref = "INTLIST"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(INTLIST).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "INTLIST"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(INTLIST), Is.EqualTo(1612));
    }
}