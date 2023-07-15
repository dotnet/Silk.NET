// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "RESUME_PERFORMANCE"/> struct.</summary>
public static unsafe partial class RESUME_PERFORMANCETests
{
    /// <summary>Validates that the <see cref = "RESUME_PERFORMANCE"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<RESUME_PERFORMANCE>(), Is.EqualTo(sizeof(RESUME_PERFORMANCE)));
    }

    /// <summary>Validates that the <see cref = "RESUME_PERFORMANCE"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(RESUME_PERFORMANCE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "RESUME_PERFORMANCE"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(RESUME_PERFORMANCE), Is.EqualTo(24));
    }
}