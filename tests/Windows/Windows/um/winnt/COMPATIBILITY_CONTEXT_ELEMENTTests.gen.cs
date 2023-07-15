// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "COMPATIBILITY_CONTEXT_ELEMENT"/> struct.</summary>
public static unsafe partial class COMPATIBILITY_CONTEXT_ELEMENTTests
{
    /// <summary>Validates that the <see cref = "COMPATIBILITY_CONTEXT_ELEMENT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<COMPATIBILITY_CONTEXT_ELEMENT>(), Is.EqualTo(sizeof(COMPATIBILITY_CONTEXT_ELEMENT)));
    }

    /// <summary>Validates that the <see cref = "COMPATIBILITY_CONTEXT_ELEMENT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(COMPATIBILITY_CONTEXT_ELEMENT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "COMPATIBILITY_CONTEXT_ELEMENT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(COMPATIBILITY_CONTEXT_ELEMENT), Is.EqualTo(32));
    }
}