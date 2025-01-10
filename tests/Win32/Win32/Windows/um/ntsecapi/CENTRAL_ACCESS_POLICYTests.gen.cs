// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "CENTRAL_ACCESS_POLICY"/> struct.</summary>
public static unsafe partial class CENTRAL_ACCESS_POLICYTests
{
    /// <summary>Validates that the <see cref = "CENTRAL_ACCESS_POLICY"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<CENTRAL_ACCESS_POLICY>(),
            Is.EqualTo(sizeof(CENTRAL_ACCESS_POLICY))
        );
    }

    /// <summary>Validates that the <see cref = "CENTRAL_ACCESS_POLICY"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CENTRAL_ACCESS_POLICY).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CENTRAL_ACCESS_POLICY"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CENTRAL_ACCESS_POLICY), Is.EqualTo(72));
        }
        else
        {
            Assert.That(sizeof(CENTRAL_ACCESS_POLICY), Is.EqualTo(40));
        }
    }
}
