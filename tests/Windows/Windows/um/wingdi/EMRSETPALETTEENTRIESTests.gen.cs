// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "EMRSETPALETTEENTRIES"/> struct.</summary>
public static unsafe partial class EMRSETPALETTEENTRIESTests
{
    /// <summary>Validates that the <see cref = "EMRSETPALETTEENTRIES"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<EMRSETPALETTEENTRIES>(), Is.EqualTo(sizeof(EMRSETPALETTEENTRIES)));
    }

    /// <summary>Validates that the <see cref = "EMRSETPALETTEENTRIES"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(EMRSETPALETTEENTRIES).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "EMRSETPALETTEENTRIES"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(EMRSETPALETTEENTRIES), Is.EqualTo(24));
    }
}