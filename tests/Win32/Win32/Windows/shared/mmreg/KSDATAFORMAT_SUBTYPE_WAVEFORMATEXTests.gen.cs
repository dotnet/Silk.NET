// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "KSDATAFORMAT_SUBTYPE_WAVEFORMATEX"/> struct.</summary>
public static unsafe partial class KSDATAFORMAT_SUBTYPE_WAVEFORMATEXTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "KSDATAFORMAT_SUBTYPE_WAVEFORMATEX"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(KSDATAFORMAT_SUBTYPE_WAVEFORMATEX).GUID,
            Is.EqualTo(IID_KSDATAFORMAT_SUBTYPE_WAVEFORMATEX)
        );
    }

    /// <summary>Validates that the <see cref = "KSDATAFORMAT_SUBTYPE_WAVEFORMATEX"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<KSDATAFORMAT_SUBTYPE_WAVEFORMATEX>(),
            Is.EqualTo(sizeof(KSDATAFORMAT_SUBTYPE_WAVEFORMATEX))
        );
    }

    /// <summary>Validates that the <see cref = "KSDATAFORMAT_SUBTYPE_WAVEFORMATEX"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(KSDATAFORMAT_SUBTYPE_WAVEFORMATEX).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "KSDATAFORMAT_SUBTYPE_WAVEFORMATEX"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(KSDATAFORMAT_SUBTYPE_WAVEFORMATEX), Is.EqualTo(1));
    }
}
