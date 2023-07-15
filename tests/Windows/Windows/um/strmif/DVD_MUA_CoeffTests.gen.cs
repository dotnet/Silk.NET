// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "DVD_MUA_Coeff"/> struct.</summary>
public static unsafe partial class DVD_MUA_CoeffTests
{
    /// <summary>Validates that the <see cref = "DVD_MUA_Coeff"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DVD_MUA_Coeff>(), Is.EqualTo(sizeof(DVD_MUA_Coeff)));
    }

    /// <summary>Validates that the <see cref = "DVD_MUA_Coeff"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DVD_MUA_Coeff).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DVD_MUA_Coeff"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DVD_MUA_Coeff), Is.EqualTo(16));
    }
}