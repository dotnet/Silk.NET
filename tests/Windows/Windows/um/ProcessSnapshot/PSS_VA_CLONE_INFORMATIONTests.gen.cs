// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "PSS_VA_CLONE_INFORMATION"/> struct.</summary>
[SupportedOSPlatform("windows6.3")]
public static unsafe partial class PSS_VA_CLONE_INFORMATIONTests
{
    /// <summary>Validates that the <see cref = "PSS_VA_CLONE_INFORMATION"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PSS_VA_CLONE_INFORMATION>(), Is.EqualTo(sizeof(PSS_VA_CLONE_INFORMATION)));
    }

    /// <summary>Validates that the <see cref = "PSS_VA_CLONE_INFORMATION"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PSS_VA_CLONE_INFORMATION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PSS_VA_CLONE_INFORMATION"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PSS_VA_CLONE_INFORMATION), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(PSS_VA_CLONE_INFORMATION), Is.EqualTo(4));
        }
    }
}