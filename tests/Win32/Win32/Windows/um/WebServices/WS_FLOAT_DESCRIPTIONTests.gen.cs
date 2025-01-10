// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "WS_FLOAT_DESCRIPTION"/> struct.</summary>
public static unsafe partial class WS_FLOAT_DESCRIPTIONTests
{
    /// <summary>Validates that the <see cref = "WS_FLOAT_DESCRIPTION"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<WS_FLOAT_DESCRIPTION>(),
            Is.EqualTo(sizeof(WS_FLOAT_DESCRIPTION))
        );
    }

    /// <summary>Validates that the <see cref = "WS_FLOAT_DESCRIPTION"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WS_FLOAT_DESCRIPTION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WS_FLOAT_DESCRIPTION"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(WS_FLOAT_DESCRIPTION), Is.EqualTo(8));
    }
}
