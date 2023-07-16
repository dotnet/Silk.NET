// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "LHITTESTINFO"/> struct.</summary>
public static unsafe partial class LHITTESTINFOTests
{
    /// <summary>Validates that the <see cref = "LHITTESTINFO"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<LHITTESTINFO>(), Is.EqualTo(sizeof(LHITTESTINFO)));
    }

    /// <summary>Validates that the <see cref = "LHITTESTINFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(LHITTESTINFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "LHITTESTINFO"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(LHITTESTINFO), Is.EqualTo(4288));
    }
}