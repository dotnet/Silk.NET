// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "PROCESSOR_NUMBER"/> struct.</summary>
public static unsafe partial class PROCESSOR_NUMBERTests
{
    /// <summary>Validates that the <see cref = "PROCESSOR_NUMBER"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PROCESSOR_NUMBER>(), Is.EqualTo(sizeof(PROCESSOR_NUMBER)));
    }

    /// <summary>Validates that the <see cref = "PROCESSOR_NUMBER"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PROCESSOR_NUMBER).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PROCESSOR_NUMBER"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(PROCESSOR_NUMBER), Is.EqualTo(4));
    }
}