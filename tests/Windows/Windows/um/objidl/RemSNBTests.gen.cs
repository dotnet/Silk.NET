// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "RemSNB"/> struct.</summary>
public static unsafe partial class RemSNBTests
{
    /// <summary>Validates that the <see cref = "RemSNB"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<RemSNB>(), Is.EqualTo(sizeof(RemSNB)));
    }

    /// <summary>Validates that the <see cref = "RemSNB"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(RemSNB).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "RemSNB"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(RemSNB), Is.EqualTo(12));
    }
}