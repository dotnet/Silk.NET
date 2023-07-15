// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "RemHGLOBAL"/> struct.</summary>
public static unsafe partial class RemHGLOBALTests
{
    /// <summary>Validates that the <see cref = "RemHGLOBAL"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<RemHGLOBAL>(), Is.EqualTo(sizeof(RemHGLOBAL)));
    }

    /// <summary>Validates that the <see cref = "RemHGLOBAL"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(RemHGLOBAL).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "RemHGLOBAL"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(RemHGLOBAL), Is.EqualTo(12));
    }
}