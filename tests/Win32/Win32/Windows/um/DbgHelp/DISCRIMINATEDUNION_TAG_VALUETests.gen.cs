// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "DISCRIMINATEDUNION_TAG_VALUE"/> struct.</summary>
public static unsafe partial class DISCRIMINATEDUNION_TAG_VALUETests
{
    /// <summary>Validates that the <see cref = "DISCRIMINATEDUNION_TAG_VALUE"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DISCRIMINATEDUNION_TAG_VALUE>(),
            Is.EqualTo(sizeof(DISCRIMINATEDUNION_TAG_VALUE))
        );
    }

    /// <summary>Validates that the <see cref = "DISCRIMINATEDUNION_TAG_VALUE"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DISCRIMINATEDUNION_TAG_VALUE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DISCRIMINATEDUNION_TAG_VALUE"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DISCRIMINATEDUNION_TAG_VALUE), Is.EqualTo(17));
    }
}
