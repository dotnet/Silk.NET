// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SPEVENTEX"/> struct.</summary>
public static unsafe partial class SPEVENTEXTests
{
    /// <summary>Validates that the <see cref = "SPEVENTEX"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SPEVENTEX>(), Is.EqualTo(sizeof(SPEVENTEX)));
    }

    /// <summary>Validates that the <see cref = "SPEVENTEX"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SPEVENTEX).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SPEVENTEX"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SPEVENTEX), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(SPEVENTEX), Is.EqualTo(32));
        }
    }
}