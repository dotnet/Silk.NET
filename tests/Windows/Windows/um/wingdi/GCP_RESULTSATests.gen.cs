// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "GCP_RESULTSA"/> struct.</summary>
public static unsafe partial class GCP_RESULTSATests
{
    /// <summary>Validates that the <see cref = "GCP_RESULTSA"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<GCP_RESULTSA>(), Is.EqualTo(sizeof(GCP_RESULTSA)));
    }

    /// <summary>Validates that the <see cref = "GCP_RESULTSA"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(GCP_RESULTSA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "GCP_RESULTSA"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(GCP_RESULTSA), Is.EqualTo(64));
        }
        else
        {
            Assert.That(sizeof(GCP_RESULTSA), Is.EqualTo(36));
        }
    }
}