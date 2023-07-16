// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "WIN32_FIND_DATAW"/> struct.</summary>
public static unsafe partial class WIN32_FIND_DATAWTests
{
    /// <summary>Validates that the <see cref = "WIN32_FIND_DATAW"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WIN32_FIND_DATAW>(), Is.EqualTo(sizeof(WIN32_FIND_DATAW)));
    }

    /// <summary>Validates that the <see cref = "WIN32_FIND_DATAW"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WIN32_FIND_DATAW).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WIN32_FIND_DATAW"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(WIN32_FIND_DATAW), Is.EqualTo(592));
    }
}