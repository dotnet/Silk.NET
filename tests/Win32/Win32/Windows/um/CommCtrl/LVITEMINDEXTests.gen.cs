// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "LVITEMINDEX"/> struct.</summary>
public static unsafe partial class LVITEMINDEXTests
{
    /// <summary>Validates that the <see cref = "LVITEMINDEX"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<LVITEMINDEX>(), Is.EqualTo(sizeof(LVITEMINDEX)));
    }

    /// <summary>Validates that the <see cref = "LVITEMINDEX"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(LVITEMINDEX).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "LVITEMINDEX"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(LVITEMINDEX), Is.EqualTo(8));
    }
}
