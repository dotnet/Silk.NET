// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "KERNEL_CET_CONTEXT"/> struct.</summary>
public static unsafe partial class KERNEL_CET_CONTEXTTests
{
    /// <summary>Validates that the <see cref = "KERNEL_CET_CONTEXT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<KERNEL_CET_CONTEXT>(), Is.EqualTo(sizeof(KERNEL_CET_CONTEXT)));
    }

    /// <summary>Validates that the <see cref = "KERNEL_CET_CONTEXT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(KERNEL_CET_CONTEXT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "KERNEL_CET_CONTEXT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(KERNEL_CET_CONTEXT), Is.EqualTo(24));
    }
}