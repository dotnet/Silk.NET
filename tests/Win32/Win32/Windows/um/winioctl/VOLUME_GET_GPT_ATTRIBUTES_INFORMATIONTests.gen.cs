// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "VOLUME_GET_GPT_ATTRIBUTES_INFORMATION"/> struct.</summary>
public static unsafe partial class VOLUME_GET_GPT_ATTRIBUTES_INFORMATIONTests
{
    /// <summary>Validates that the <see cref = "VOLUME_GET_GPT_ATTRIBUTES_INFORMATION"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<VOLUME_GET_GPT_ATTRIBUTES_INFORMATION>(),
            Is.EqualTo(sizeof(VOLUME_GET_GPT_ATTRIBUTES_INFORMATION))
        );
    }

    /// <summary>Validates that the <see cref = "VOLUME_GET_GPT_ATTRIBUTES_INFORMATION"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(VOLUME_GET_GPT_ATTRIBUTES_INFORMATION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "VOLUME_GET_GPT_ATTRIBUTES_INFORMATION"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(VOLUME_GET_GPT_ATTRIBUTES_INFORMATION), Is.EqualTo(8));
    }
}
