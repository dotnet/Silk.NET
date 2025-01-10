// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/consoleapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "ALLOC_CONSOLE_OPTIONS"/> struct.</summary>
public static unsafe partial class ALLOC_CONSOLE_OPTIONSTests
{
    /// <summary>Validates that the <see cref = "ALLOC_CONSOLE_OPTIONS"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ALLOC_CONSOLE_OPTIONS>(),
            Is.EqualTo(sizeof(ALLOC_CONSOLE_OPTIONS))
        );
    }

    /// <summary>Validates that the <see cref = "ALLOC_CONSOLE_OPTIONS"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ALLOC_CONSOLE_OPTIONS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ALLOC_CONSOLE_OPTIONS"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ALLOC_CONSOLE_OPTIONS), Is.EqualTo(12));
    }
}
