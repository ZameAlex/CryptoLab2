using System;
using System.Collections.Generic;
using System.Text;

namespace DES
{
    interface ICommonProcess
    {
        string EncryptionStart(string text, string key);
        string DecryptionStart(string text, string key);
    }
}
