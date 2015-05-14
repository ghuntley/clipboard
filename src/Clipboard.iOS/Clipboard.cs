using System;
using UIKit;

namespace Clipboard.iOS
{
    /// <summary>
    /// https://gist.github.com/ghuntley/817d2fc0df1688c4a5f2
    /// </summary>
    /// http://www.kevfoo.com/2010/01/monotouch-quickie-uipasteboard-snippet/
    /// http://technet.weblineindia.com/mobile/sharing-data-using-uipasteboard-in-ios-app/
    public class Clipboard : IClipboard
    {

        public Clipboard()
        {
            UIPasteboard.General.Images.
        }
    }
}

