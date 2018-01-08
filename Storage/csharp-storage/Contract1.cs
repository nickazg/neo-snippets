using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;
using Neo.SmartContract.Framework.Services.System;
using System;
using System.Numerics;

namespace CSharpStorage
{
    public class TestContract : Neo.SmartContract.Framework.SmartContract
    {
        public static int Main(string operation, string key, int x)
        {
            if (operation == "print")
            {
                Runtime.Log("Hello nickazg");

                return 1;
            }

            if (operation == "write")
            {
                Storage.Put(Storage.CurrentContext, key, x);

                Runtime.Notify("The number was stored", key, x);

                return 2;
            }

            if (operation == "read")
            {
                byte[] bytes = Storage.Get(Storage.CurrentContext, key);

                BigInteger y = bytes.AsBigInteger();

                Runtime.Notify("y", y);

                for (int i = 0; i < 5; i++)
                {
                    y = 2 * y;
                    Runtime.Notify("y = 2 * y", y);
                }

                return 3;
            }

            return 404;
        }
    }
}
