// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winternl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "STRING"/> struct.</summary>
public static unsafe partial class STRINGTests
{
    /// <summary>Validates that the <see cref = "STRING"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<STRING>(), Is.EqualTo(sizeof(STRING)));
    }

    /// <summary>Validates that the <see cref = "STRING"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(STRING).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "STRING"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(STRING), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(STRING), Is.EqualTo(8));
        }
    }
}