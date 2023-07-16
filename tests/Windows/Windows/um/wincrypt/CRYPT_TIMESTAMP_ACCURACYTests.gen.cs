// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CRYPT_TIMESTAMP_ACCURACY"/> struct.</summary>
public static unsafe partial class CRYPT_TIMESTAMP_ACCURACYTests
{
    /// <summary>Validates that the <see cref = "CRYPT_TIMESTAMP_ACCURACY"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CRYPT_TIMESTAMP_ACCURACY>(), Is.EqualTo(sizeof(CRYPT_TIMESTAMP_ACCURACY)));
    }

    /// <summary>Validates that the <see cref = "CRYPT_TIMESTAMP_ACCURACY"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CRYPT_TIMESTAMP_ACCURACY).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CRYPT_TIMESTAMP_ACCURACY"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(CRYPT_TIMESTAMP_ACCURACY), Is.EqualTo(12));
    }
}