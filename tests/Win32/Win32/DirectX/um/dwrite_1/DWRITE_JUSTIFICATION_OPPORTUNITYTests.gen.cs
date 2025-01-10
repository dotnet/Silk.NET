// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DWRITE_JUSTIFICATION_OPPORTUNITY"/> struct.</summary>
public static unsafe partial class DWRITE_JUSTIFICATION_OPPORTUNITYTests
{
    /// <summary>Validates that the <see cref = "DWRITE_JUSTIFICATION_OPPORTUNITY"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<DWRITE_JUSTIFICATION_OPPORTUNITY>(),
            Is.EqualTo(sizeof(DWRITE_JUSTIFICATION_OPPORTUNITY))
        );
    }

    /// <summary>Validates that the <see cref = "DWRITE_JUSTIFICATION_OPPORTUNITY"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DWRITE_JUSTIFICATION_OPPORTUNITY).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DWRITE_JUSTIFICATION_OPPORTUNITY"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DWRITE_JUSTIFICATION_OPPORTUNITY), Is.EqualTo(16));
    }
}
