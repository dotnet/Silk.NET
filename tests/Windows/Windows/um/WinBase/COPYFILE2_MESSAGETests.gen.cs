// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "COPYFILE2_MESSAGE"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class COPYFILE2_MESSAGETests
{
    /// <summary>Validates that the <see cref = "COPYFILE2_MESSAGE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<COPYFILE2_MESSAGE>(), Is.EqualTo(sizeof(COPYFILE2_MESSAGE)));
    }

    /// <summary>Validates that the <see cref = "COPYFILE2_MESSAGE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(COPYFILE2_MESSAGE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "COPYFILE2_MESSAGE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(COPYFILE2_MESSAGE), Is.EqualTo(80));
        }
        else
        {
            Assert.That(sizeof(COPYFILE2_MESSAGE), Is.EqualTo(72));
        }
    }
}