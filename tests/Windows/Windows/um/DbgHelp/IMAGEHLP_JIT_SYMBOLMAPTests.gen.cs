// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMAGEHLP_JIT_SYMBOLMAP"/> struct.</summary>
public static unsafe partial class IMAGEHLP_JIT_SYMBOLMAPTests
{
    /// <summary>Validates that the <see cref = "IMAGEHLP_JIT_SYMBOLMAP"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMAGEHLP_JIT_SYMBOLMAP>(), Is.EqualTo(sizeof(IMAGEHLP_JIT_SYMBOLMAP)));
    }

    /// <summary>Validates that the <see cref = "IMAGEHLP_JIT_SYMBOLMAP"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMAGEHLP_JIT_SYMBOLMAP).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMAGEHLP_JIT_SYMBOLMAP"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(IMAGEHLP_JIT_SYMBOLMAP), Is.EqualTo(24));
    }
}