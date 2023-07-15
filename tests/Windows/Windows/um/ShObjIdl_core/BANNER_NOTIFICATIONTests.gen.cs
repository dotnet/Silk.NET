// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "BANNER_NOTIFICATION"/> struct.</summary>
public static unsafe partial class BANNER_NOTIFICATIONTests
{
    /// <summary>Validates that the <see cref = "BANNER_NOTIFICATION"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<BANNER_NOTIFICATION>(), Is.EqualTo(sizeof(BANNER_NOTIFICATION)));
    }

    /// <summary>Validates that the <see cref = "BANNER_NOTIFICATION"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(BANNER_NOTIFICATION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "BANNER_NOTIFICATION"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(BANNER_NOTIFICATION), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(BANNER_NOTIFICATION), Is.EqualTo(12));
        }
    }
}