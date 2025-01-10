// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "NMDATETIMESTRINGW"/> struct.</summary>
public static unsafe partial class NMDATETIMESTRINGWTests
{
    /// <summary>Validates that the <see cref = "NMDATETIMESTRINGW"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<NMDATETIMESTRINGW>(), Is.EqualTo(sizeof(NMDATETIMESTRINGW)));
    }

    /// <summary>Validates that the <see cref = "NMDATETIMESTRINGW"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(NMDATETIMESTRINGW).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "NMDATETIMESTRINGW"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(NMDATETIMESTRINGW), Is.EqualTo(56));
        }
        else
        {
            Assert.That(sizeof(NMDATETIMESTRINGW), Is.EqualTo(36));
        }
    }
}
