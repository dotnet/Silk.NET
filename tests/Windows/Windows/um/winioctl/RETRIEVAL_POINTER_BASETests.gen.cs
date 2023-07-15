// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "RETRIEVAL_POINTER_BASE"/> struct.</summary>
public static unsafe partial class RETRIEVAL_POINTER_BASETests
{
    /// <summary>Validates that the <see cref = "RETRIEVAL_POINTER_BASE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<RETRIEVAL_POINTER_BASE>(), Is.EqualTo(sizeof(RETRIEVAL_POINTER_BASE)));
    }

    /// <summary>Validates that the <see cref = "RETRIEVAL_POINTER_BASE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(RETRIEVAL_POINTER_BASE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "RETRIEVAL_POINTER_BASE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(RETRIEVAL_POINTER_BASE), Is.EqualTo(8));
    }
}