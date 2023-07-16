// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CAT_NAMEVALUE"/> struct.</summary>
public static unsafe partial class CAT_NAMEVALUETests
{
    /// <summary>Validates that the <see cref = "CAT_NAMEVALUE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CAT_NAMEVALUE>(), Is.EqualTo(sizeof(CAT_NAMEVALUE)));
    }

    /// <summary>Validates that the <see cref = "CAT_NAMEVALUE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CAT_NAMEVALUE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CAT_NAMEVALUE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CAT_NAMEVALUE), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(CAT_NAMEVALUE), Is.EqualTo(16));
        }
    }
}