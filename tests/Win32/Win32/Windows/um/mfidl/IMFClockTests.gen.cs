// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IMFClock"/> struct.</summary>
public static unsafe partial class IMFClockTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMFClock"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFClock).GUID, Is.EqualTo(IID_IMFClock));
    }

    /// <summary>Validates that the <see cref = "IMFClock"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFClock>(), Is.EqualTo(sizeof(IMFClock)));
    }

    /// <summary>Validates that the <see cref = "IMFClock"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFClock).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMFClock"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFClock), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFClock), Is.EqualTo(4));
        }
    }
}
