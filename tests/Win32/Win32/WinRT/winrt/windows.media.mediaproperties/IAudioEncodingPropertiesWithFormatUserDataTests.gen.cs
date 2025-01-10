// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IAudioEncodingPropertiesWithFormatUserData"/> struct.</summary>
public static unsafe partial class IAudioEncodingPropertiesWithFormatUserDataTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IAudioEncodingPropertiesWithFormatUserData"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IAudioEncodingPropertiesWithFormatUserData).GUID,
            Is.EqualTo(IID_IAudioEncodingPropertiesWithFormatUserData)
        );
    }

    /// <summary>Validates that the <see cref = "IAudioEncodingPropertiesWithFormatUserData"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IAudioEncodingPropertiesWithFormatUserData>(),
            Is.EqualTo(sizeof(IAudioEncodingPropertiesWithFormatUserData))
        );
    }

    /// <summary>Validates that the <see cref = "IAudioEncodingPropertiesWithFormatUserData"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IAudioEncodingPropertiesWithFormatUserData).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IAudioEncodingPropertiesWithFormatUserData"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IAudioEncodingPropertiesWithFormatUserData), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IAudioEncodingPropertiesWithFormatUserData), Is.EqualTo(4));
        }
    }
}
