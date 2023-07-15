// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "DVEXTENTINFO"/> struct.</summary>
public static unsafe partial class DVEXTENTINFOTests
{
    /// <summary>Validates that the <see cref = "DVEXTENTINFO"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DVEXTENTINFO>(), Is.EqualTo(sizeof(DVEXTENTINFO)));
    }

    /// <summary>Validates that the <see cref = "DVEXTENTINFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DVEXTENTINFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DVEXTENTINFO"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DVEXTENTINFO), Is.EqualTo(16));
    }
}