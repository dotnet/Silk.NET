// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY_XDATA_EXTENDED"/> struct.</summary>
public static unsafe partial class IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY_XDATA_EXTENDEDTests
{
    /// <summary>Validates that the <see cref = "IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY_XDATA_EXTENDED"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY_XDATA_EXTENDED>(),
            Is.EqualTo(sizeof(IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY_XDATA_EXTENDED))
        );
    }

    /// <summary>Validates that the <see cref = "IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY_XDATA_EXTENDED"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutExplicitTest()
    {
        Assert.That(
            typeof(IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY_XDATA_EXTENDED).IsExplicitLayout,
            Is.True
        );
    }

    /// <summary>Validates that the <see cref = "IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY_XDATA_EXTENDED"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY_XDATA_EXTENDED), Is.EqualTo(4));
    }
}
