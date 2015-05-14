using System;

namespace Clipboard
{
    public interface IClipboard
    {
        string Get();

        byte[] Get();

        void Set();

        void Clear();
    }
}

