// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMAGEHLP_STACK_FRAME"/> struct.</summary>
public static unsafe partial class IMAGEHLP_STACK_FRAMETests
{
    /// <summary>Validates that the <see cref = "IMAGEHLP_STACK_FRAME"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMAGEHLP_STACK_FRAME>(), Is.EqualTo(sizeof(IMAGEHLP_STACK_FRAME)));
    }

    /// <summary>Validates that the <see cref = "IMAGEHLP_STACK_FRAME"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMAGEHLP_STACK_FRAME).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMAGEHLP_STACK_FRAME"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(IMAGEHLP_STACK_FRAME), Is.EqualTo(128));
    }
}