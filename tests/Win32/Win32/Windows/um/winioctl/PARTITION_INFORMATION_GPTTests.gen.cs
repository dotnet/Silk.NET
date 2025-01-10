// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "PARTITION_INFORMATION_GPT"/> struct.</summary>
public static unsafe partial class PARTITION_INFORMATION_GPTTests
{
    /// <summary>Validates that the <see cref = "PARTITION_INFORMATION_GPT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<PARTITION_INFORMATION_GPT>(),
            Is.EqualTo(sizeof(PARTITION_INFORMATION_GPT))
        );
    }

    /// <summary>Validates that the <see cref = "PARTITION_INFORMATION_GPT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PARTITION_INFORMATION_GPT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PARTITION_INFORMATION_GPT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(PARTITION_INFORMATION_GPT), Is.EqualTo(112));
    }
}
