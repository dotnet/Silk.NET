// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MsftDiscRecorder2"/> struct.</summary>
public static unsafe partial class MsftDiscRecorder2Tests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "MsftDiscRecorder2"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(MsftDiscRecorder2).GUID, Is.EqualTo(CLSID_MsftDiscRecorder2));
    }

    /// <summary>Validates that the <see cref = "MsftDiscRecorder2"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MsftDiscRecorder2>(), Is.EqualTo(sizeof(MsftDiscRecorder2)));
    }

    /// <summary>Validates that the <see cref = "MsftDiscRecorder2"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MsftDiscRecorder2).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MsftDiscRecorder2"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MsftDiscRecorder2), Is.EqualTo(1));
    }
}