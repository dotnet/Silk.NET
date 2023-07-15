// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "EMRMODIFYWORLDTRANSFORM"/> struct.</summary>
public static unsafe partial class EMRMODIFYWORLDTRANSFORMTests
{
    /// <summary>Validates that the <see cref = "EMRMODIFYWORLDTRANSFORM"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<EMRMODIFYWORLDTRANSFORM>(), Is.EqualTo(sizeof(EMRMODIFYWORLDTRANSFORM)));
    }

    /// <summary>Validates that the <see cref = "EMRMODIFYWORLDTRANSFORM"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(EMRMODIFYWORLDTRANSFORM).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "EMRMODIFYWORLDTRANSFORM"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(EMRMODIFYWORLDTRANSFORM), Is.EqualTo(36));
    }
}