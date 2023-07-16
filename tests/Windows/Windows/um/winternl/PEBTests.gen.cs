// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winternl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "PEB"/> struct.</summary>
public static unsafe partial class PEBTests
{
    /// <summary>Validates that the <see cref = "PEB"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PEB>(), Is.EqualTo(sizeof(PEB)));
    }

    /// <summary>Validates that the <see cref = "PEB"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PEB).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PEB"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PEB), Is.EqualTo(712));
        }
        else
        {
            Assert.That(sizeof(PEB), Is.EqualTo(472));
        }
    }
}