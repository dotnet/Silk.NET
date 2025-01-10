// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winreg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "REG_PROVIDER"/> struct.</summary>
public static unsafe partial class REG_PROVIDERTests
{
    /// <summary>Validates that the <see cref = "REG_PROVIDER"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<REG_PROVIDER>(), Is.EqualTo(sizeof(REG_PROVIDER)));
    }

    /// <summary>Validates that the <see cref = "REG_PROVIDER"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(REG_PROVIDER).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "REG_PROVIDER"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(REG_PROVIDER), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(REG_PROVIDER), Is.EqualTo(24));
        }
    }
}
