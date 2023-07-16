// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UserEnv.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "POLICYSETTINGSTATUSINFO"/> struct.</summary>
public static unsafe partial class POLICYSETTINGSTATUSINFOTests
{
    /// <summary>Validates that the <see cref = "POLICYSETTINGSTATUSINFO"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<POLICYSETTINGSTATUSINFO>(), Is.EqualTo(sizeof(POLICYSETTINGSTATUSINFO)));
    }

    /// <summary>Validates that the <see cref = "POLICYSETTINGSTATUSINFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(POLICYSETTINGSTATUSINFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "POLICYSETTINGSTATUSINFO"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(POLICYSETTINGSTATUSINFO), Is.EqualTo(56));
        }
        else
        {
            Assert.That(sizeof(POLICYSETTINGSTATUSINFO), Is.EqualTo(40));
        }
    }
}