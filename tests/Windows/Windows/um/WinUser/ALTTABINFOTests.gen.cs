// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ALTTABINFO"/> struct.</summary>
public static unsafe partial class ALTTABINFOTests
{
    /// <summary>Validates that the <see cref = "ALTTABINFO"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ALTTABINFO>(), Is.EqualTo(sizeof(ALTTABINFO)));
    }

    /// <summary>Validates that the <see cref = "ALTTABINFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ALTTABINFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ALTTABINFO"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ALTTABINFO), Is.EqualTo(40));
    }
}