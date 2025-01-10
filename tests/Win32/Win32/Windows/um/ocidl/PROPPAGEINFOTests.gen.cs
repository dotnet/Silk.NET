// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "PROPPAGEINFO"/> struct.</summary>
public static unsafe partial class PROPPAGEINFOTests
{
    /// <summary>Validates that the <see cref = "PROPPAGEINFO"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PROPPAGEINFO>(), Is.EqualTo(sizeof(PROPPAGEINFO)));
    }

    /// <summary>Validates that the <see cref = "PROPPAGEINFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PROPPAGEINFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PROPPAGEINFO"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PROPPAGEINFO), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(PROPPAGEINFO), Is.EqualTo(28));
        }
    }
}
