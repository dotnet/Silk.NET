// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/LsaLookup.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "LSA_REFERENCED_DOMAIN_LIST"/> struct.</summary>
public static unsafe partial class LSA_REFERENCED_DOMAIN_LISTTests
{
    /// <summary>Validates that the <see cref = "LSA_REFERENCED_DOMAIN_LIST"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<LSA_REFERENCED_DOMAIN_LIST>(), Is.EqualTo(sizeof(LSA_REFERENCED_DOMAIN_LIST)));
    }

    /// <summary>Validates that the <see cref = "LSA_REFERENCED_DOMAIN_LIST"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(LSA_REFERENCED_DOMAIN_LIST).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "LSA_REFERENCED_DOMAIN_LIST"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(LSA_REFERENCED_DOMAIN_LIST), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(LSA_REFERENCED_DOMAIN_LIST), Is.EqualTo(8));
        }
    }
}