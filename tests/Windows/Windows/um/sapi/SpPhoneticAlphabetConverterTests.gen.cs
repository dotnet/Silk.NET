// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SpPhoneticAlphabetConverter"/> struct.</summary>
public static unsafe partial class SpPhoneticAlphabetConverterTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "SpPhoneticAlphabetConverter"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(SpPhoneticAlphabetConverter).GUID, Is.EqualTo(IID_SpPhoneticAlphabetConverter));
    }

    /// <summary>Validates that the <see cref = "SpPhoneticAlphabetConverter"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SpPhoneticAlphabetConverter>(), Is.EqualTo(sizeof(SpPhoneticAlphabetConverter)));
    }

    /// <summary>Validates that the <see cref = "SpPhoneticAlphabetConverter"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SpPhoneticAlphabetConverter).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SpPhoneticAlphabetConverter"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SpPhoneticAlphabetConverter), Is.EqualTo(1));
    }
}