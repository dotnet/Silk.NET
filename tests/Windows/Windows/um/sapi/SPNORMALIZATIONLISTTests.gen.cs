// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SPNORMALIZATIONLIST"/> struct.</summary>
public static unsafe partial class SPNORMALIZATIONLISTTests
{
    /// <summary>Validates that the <see cref = "SPNORMALIZATIONLIST"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SPNORMALIZATIONLIST>(), Is.EqualTo(sizeof(SPNORMALIZATIONLIST)));
    }

    /// <summary>Validates that the <see cref = "SPNORMALIZATIONLIST"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SPNORMALIZATIONLIST).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SPNORMALIZATIONLIST"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SPNORMALIZATIONLIST), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(SPNORMALIZATIONLIST), Is.EqualTo(8));
        }
    }
}