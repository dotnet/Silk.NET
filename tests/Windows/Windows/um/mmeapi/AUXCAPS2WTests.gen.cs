// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "AUXCAPS2W"/> struct.</summary>
public static unsafe partial class AUXCAPS2WTests
{
    /// <summary>Validates that the <see cref = "AUXCAPS2W"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AUXCAPS2W>(), Is.EqualTo(sizeof(AUXCAPS2W)));
    }

    /// <summary>Validates that the <see cref = "AUXCAPS2W"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AUXCAPS2W).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "AUXCAPS2W"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(AUXCAPS2W), Is.EqualTo(128));
    }
}