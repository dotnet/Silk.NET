// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "COPYFILE2_EXTENDED_PARAMETERS"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class COPYFILE2_EXTENDED_PARAMETERSTests
{
    /// <summary>Validates that the <see cref = "COPYFILE2_EXTENDED_PARAMETERS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<COPYFILE2_EXTENDED_PARAMETERS>(), Is.EqualTo(sizeof(COPYFILE2_EXTENDED_PARAMETERS)));
    }

    /// <summary>Validates that the <see cref = "COPYFILE2_EXTENDED_PARAMETERS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(COPYFILE2_EXTENDED_PARAMETERS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "COPYFILE2_EXTENDED_PARAMETERS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(COPYFILE2_EXTENDED_PARAMETERS), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(COPYFILE2_EXTENDED_PARAMETERS), Is.EqualTo(20));
        }
    }
}