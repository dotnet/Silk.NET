// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IMAGEHLP_SYMBOLW64_PACKAGE"/> struct.</summary>
public static unsafe partial class IMAGEHLP_SYMBOLW64_PACKAGETests
{
    /// <summary>Validates that the <see cref = "IMAGEHLP_SYMBOLW64_PACKAGE"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IMAGEHLP_SYMBOLW64_PACKAGE>(),
            Is.EqualTo(sizeof(IMAGEHLP_SYMBOLW64_PACKAGE))
        );
    }

    /// <summary>Validates that the <see cref = "IMAGEHLP_SYMBOLW64_PACKAGE"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMAGEHLP_SYMBOLW64_PACKAGE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMAGEHLP_SYMBOLW64_PACKAGE"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(IMAGEHLP_SYMBOLW64_PACKAGE), Is.EqualTo(4040));
    }
}
