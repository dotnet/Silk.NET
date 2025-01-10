// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DDCAPS_DX5"/> struct.</summary>
public static unsafe partial class DDCAPS_DX5Tests
{
    /// <summary>Validates that the <see cref = "DDCAPS_DX5"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DDCAPS_DX5>(), Is.EqualTo(sizeof(DDCAPS_DX5)));
    }

    /// <summary>Validates that the <see cref = "DDCAPS_DX5"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DDCAPS_DX5).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DDCAPS_DX5"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DDCAPS_DX5), Is.EqualTo(364));
    }
}
