// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CLASS_MEDIA_CHANGE_CONTEXT"/> struct.</summary>
public static unsafe partial class CLASS_MEDIA_CHANGE_CONTEXTTests
{
    /// <summary>Validates that the <see cref = "CLASS_MEDIA_CHANGE_CONTEXT"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CLASS_MEDIA_CHANGE_CONTEXT>(), Is.EqualTo(sizeof(CLASS_MEDIA_CHANGE_CONTEXT)));
    }

    /// <summary>Validates that the <see cref = "CLASS_MEDIA_CHANGE_CONTEXT"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CLASS_MEDIA_CHANGE_CONTEXT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CLASS_MEDIA_CHANGE_CONTEXT"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(CLASS_MEDIA_CHANGE_CONTEXT), Is.EqualTo(8));
    }
}