// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "ACTRL_PROPERTY_ENTRYW"/> struct.</summary>
public static unsafe partial class ACTRL_PROPERTY_ENTRYWTests
{
    /// <summary>Validates that the <see cref = "ACTRL_PROPERTY_ENTRYW"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ACTRL_PROPERTY_ENTRYW>(),
            Is.EqualTo(sizeof(ACTRL_PROPERTY_ENTRYW))
        );
    }

    /// <summary>Validates that the <see cref = "ACTRL_PROPERTY_ENTRYW"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ACTRL_PROPERTY_ENTRYW).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ACTRL_PROPERTY_ENTRYW"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ACTRL_PROPERTY_ENTRYW), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(ACTRL_PROPERTY_ENTRYW), Is.EqualTo(12));
        }
    }
}
