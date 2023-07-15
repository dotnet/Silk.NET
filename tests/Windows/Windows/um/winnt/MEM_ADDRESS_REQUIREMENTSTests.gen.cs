// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MEM_ADDRESS_REQUIREMENTS"/> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class MEM_ADDRESS_REQUIREMENTSTests
{
    /// <summary>Validates that the <see cref = "MEM_ADDRESS_REQUIREMENTS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MEM_ADDRESS_REQUIREMENTS>(), Is.EqualTo(sizeof(MEM_ADDRESS_REQUIREMENTS)));
    }

    /// <summary>Validates that the <see cref = "MEM_ADDRESS_REQUIREMENTS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MEM_ADDRESS_REQUIREMENTS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MEM_ADDRESS_REQUIREMENTS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(MEM_ADDRESS_REQUIREMENTS), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(MEM_ADDRESS_REQUIREMENTS), Is.EqualTo(12));
        }
    }
}