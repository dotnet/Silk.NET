// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "INTENT_TO_SEAL_ATTRIBUTE"/> struct.</summary>
public static unsafe partial class INTENT_TO_SEAL_ATTRIBUTETests
{
    /// <summary>Validates that the <see cref = "INTENT_TO_SEAL_ATTRIBUTE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<INTENT_TO_SEAL_ATTRIBUTE>(), Is.EqualTo(sizeof(INTENT_TO_SEAL_ATTRIBUTE)));
    }

    /// <summary>Validates that the <see cref = "INTENT_TO_SEAL_ATTRIBUTE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(INTENT_TO_SEAL_ATTRIBUTE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "INTENT_TO_SEAL_ATTRIBUTE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(INTENT_TO_SEAL_ATTRIBUTE), Is.EqualTo(8));
    }
}