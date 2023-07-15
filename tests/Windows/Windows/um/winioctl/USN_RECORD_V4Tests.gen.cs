// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "USN_RECORD_V4"/> struct.</summary>
[SupportedOSPlatform("windows6.3")]
public static unsafe partial class USN_RECORD_V4Tests
{
    /// <summary>Validates that the <see cref = "USN_RECORD_V4"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<USN_RECORD_V4>(), Is.EqualTo(sizeof(USN_RECORD_V4)));
    }

    /// <summary>Validates that the <see cref = "USN_RECORD_V4"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(USN_RECORD_V4).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "USN_RECORD_V4"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(USN_RECORD_V4), Is.EqualTo(80));
    }
}