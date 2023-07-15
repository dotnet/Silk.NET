// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "RGNDATA"/> struct.</summary>
public static unsafe partial class RGNDATATests
{
    /// <summary>Validates that the <see cref = "RGNDATA"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<RGNDATA>(), Is.EqualTo(sizeof(RGNDATA)));
    }

    /// <summary>Validates that the <see cref = "RGNDATA"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(RGNDATA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "RGNDATA"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(RGNDATA), Is.EqualTo(36));
    }
}