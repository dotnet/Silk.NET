// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "FILE_SEGMENT_ELEMENT"/> struct.</summary>
public static unsafe partial class FILE_SEGMENT_ELEMENTTests
{
    /// <summary>Validates that the <see cref = "FILE_SEGMENT_ELEMENT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<FILE_SEGMENT_ELEMENT>(), Is.EqualTo(sizeof(FILE_SEGMENT_ELEMENT)));
    }

    /// <summary>Validates that the <see cref = "FILE_SEGMENT_ELEMENT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutExplicitTest()
    {
        Assert.That(typeof(FILE_SEGMENT_ELEMENT).IsExplicitLayout, Is.True);
    }

    /// <summary>Validates that the <see cref = "FILE_SEGMENT_ELEMENT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(FILE_SEGMENT_ELEMENT), Is.EqualTo(8));
    }
}