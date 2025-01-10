// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/LsaLookup.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "LSA_UNICODE_STRING"/> struct.</summary>
public static unsafe partial class LSA_UNICODE_STRINGTests
{
    /// <summary>Validates that the <see cref = "LSA_UNICODE_STRING"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<LSA_UNICODE_STRING>(), Is.EqualTo(sizeof(LSA_UNICODE_STRING)));
    }

    /// <summary>Validates that the <see cref = "LSA_UNICODE_STRING"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(LSA_UNICODE_STRING).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "LSA_UNICODE_STRING"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(LSA_UNICODE_STRING), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(LSA_UNICODE_STRING), Is.EqualTo(8));
        }
    }
}
