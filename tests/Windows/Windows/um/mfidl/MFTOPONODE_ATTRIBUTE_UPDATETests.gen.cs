// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MFTOPONODE_ATTRIBUTE_UPDATE"/> struct.</summary>
public static unsafe partial class MFTOPONODE_ATTRIBUTE_UPDATETests
{
    /// <summary>Validates that the <see cref = "MFTOPONODE_ATTRIBUTE_UPDATE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MFTOPONODE_ATTRIBUTE_UPDATE>(), Is.EqualTo(sizeof(MFTOPONODE_ATTRIBUTE_UPDATE)));
    }

    /// <summary>Validates that the <see cref = "MFTOPONODE_ATTRIBUTE_UPDATE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MFTOPONODE_ATTRIBUTE_UPDATE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MFTOPONODE_ATTRIBUTE_UPDATE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MFTOPONODE_ATTRIBUTE_UPDATE), Is.EqualTo(40));
    }
}