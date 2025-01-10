// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.CLSID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "MSDiscRecorderObj"/> struct.</summary>
public static unsafe partial class MSDiscRecorderObjTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "MSDiscRecorderObj"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(MSDiscRecorderObj).GUID, Is.EqualTo(CLSID_MSDiscRecorderObj));
    }

    /// <summary>Validates that the <see cref = "MSDiscRecorderObj"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MSDiscRecorderObj>(), Is.EqualTo(sizeof(MSDiscRecorderObj)));
    }

    /// <summary>Validates that the <see cref = "MSDiscRecorderObj"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MSDiscRecorderObj).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MSDiscRecorderObj"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MSDiscRecorderObj), Is.EqualTo(1));
    }
}
