// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.CLSID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SpFileStream"/> struct.</summary>
public static unsafe partial class SpFileStreamTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "SpFileStream"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(SpFileStream).GUID, Is.EqualTo(CLSID_SpFileStream));
    }

    /// <summary>Validates that the <see cref = "SpFileStream"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SpFileStream>(), Is.EqualTo(sizeof(SpFileStream)));
    }

    /// <summary>Validates that the <see cref = "SpFileStream"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SpFileStream).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SpFileStream"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SpFileStream), Is.EqualTo(1));
    }
}