// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MFVideoArea"/> struct.</summary>
public static unsafe partial class MFVideoAreaTests
{
    /// <summary>Validates that the <see cref = "MFVideoArea"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MFVideoArea>(), Is.EqualTo(sizeof(MFVideoArea)));
    }

    /// <summary>Validates that the <see cref = "MFVideoArea"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MFVideoArea).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MFVideoArea"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MFVideoArea), Is.EqualTo(16));
    }
}