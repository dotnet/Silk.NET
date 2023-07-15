// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "GROUP_SOURCE_REQ"/> struct.</summary>
public static unsafe partial class GROUP_SOURCE_REQTests
{
    /// <summary>Validates that the <see cref = "GROUP_SOURCE_REQ"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<GROUP_SOURCE_REQ>(), Is.EqualTo(sizeof(GROUP_SOURCE_REQ)));
    }

    /// <summary>Validates that the <see cref = "GROUP_SOURCE_REQ"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(GROUP_SOURCE_REQ).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "GROUP_SOURCE_REQ"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(GROUP_SOURCE_REQ), Is.EqualTo(264));
    }
}