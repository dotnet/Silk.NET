using System;
using Android.App;
using Silk.NET.Windowing.Common;

namespace Silk.NET.Windowing.Android
{
    public class AndroidPlatform : IWindowPlatform
    {
        public bool IsApplicable => Activity != null;
        public static Activity Activity { get; set; }
        public static AndroidWindow Current { get; set; }

        public IWindow GetWindow(WindowOptions options)
        {
            if (Current != null)
            {
                throw new NotSupportedException("Multiple windows are not supported on Android.");
            }
            return Current = new AndroidWindow(Activity, options);
        }
    }
}
