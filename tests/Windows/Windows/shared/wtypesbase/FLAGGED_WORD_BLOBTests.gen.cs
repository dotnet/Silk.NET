// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypesbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "FLAGGED_WORD_BLOB"/> struct.</summary>
public static unsafe partial class FLAGGED_WORD_BLOBTests
{
    /// <summary>Validates that the <see cref = "FLAGGED_WORD_BLOB"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<FLAGGED_WORD_BLOB>(), Is.EqualTo(sizeof(FLAGGED_WORD_BLOB)));
    }

    /// <summary>Validates that the <see cref = "FLAGGED_WORD_BLOB"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FLAGGED_WORD_BLOB).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "FLAGGED_WORD_BLOB"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(FLAGGED_WORD_BLOB), Is.EqualTo(12));
    }
}