// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SECURITY_ATTRIBUTES"/> struct.</summary>
public static unsafe partial class SECURITY_ATTRIBUTESTests
{
    /// <summary>Validates that the <see cref = "SECURITY_ATTRIBUTES"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SECURITY_ATTRIBUTES>(), Is.EqualTo(sizeof(SECURITY_ATTRIBUTES)));
    }

    /// <summary>Validates that the <see cref = "SECURITY_ATTRIBUTES"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SECURITY_ATTRIBUTES).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SECURITY_ATTRIBUTES"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SECURITY_ATTRIBUTES), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(SECURITY_ATTRIBUTES), Is.EqualTo(12));
        }
    }
}