// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "SV2CVW2_PARAMS"/> struct.</summary>
public static unsafe partial class SV2CVW2_PARAMSTests
{
    /// <summary>Validates that the <see cref = "SV2CVW2_PARAMS"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SV2CVW2_PARAMS>(), Is.EqualTo(sizeof(SV2CVW2_PARAMS)));
    }

    /// <summary>Validates that the <see cref = "SV2CVW2_PARAMS"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SV2CVW2_PARAMS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SV2CVW2_PARAMS"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SV2CVW2_PARAMS), Is.EqualTo(56));
        }
        else
        {
            Assert.That(sizeof(SV2CVW2_PARAMS), Is.EqualTo(28));
        }
    }
}
