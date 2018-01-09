using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;
using Neo.SmartContract.Framework.Services.System;
using System;

namespace BasicTemplate
{
    public class ContractTemplate : Neo.SmartContract.Framework.SmartContract
    {
        public static Object Main(string operation, params object[] args)
        {
            // Transaction Type, transations will only go through if returned true.
            if (Runtime.Trigger == TriggerType.Verification)
            {
                return true;
            }

            // Invocation transaction
            else if (Runtime.Trigger == TriggerType.Application)
            {
                if (operation == "operation_name")
                {
                    // Passing the input args appropriately into our method
                    MyMethod((byte[])args[0], (string)args[1]);
                }

                return true;
            }

            return false;

        }

        public static void MyMethod(byte[] arg1, string arg2)
        {
            // DO STUFF
        }
    }
}
