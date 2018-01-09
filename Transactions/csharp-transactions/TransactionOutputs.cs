using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;
using Neo.SmartContract.Framework.Services.System;
using System;
using System.Numerics;

namespace TransactionOutputs
{
    public class TestContract : Neo.SmartContract.Framework.SmartContract
    {
        public static void Main()
        {
            // The outputs of the transaction. 
            Transaction tx = (Transaction)ExecutionEngine.ScriptContainer;
            TransactionOutput[] outputs = tx.GetOutputs();

            // Loops though all the outputs of the transaction
            // Includes assets being sent, and also unspent assets back to sender
            foreach (TransactionOutput output in outputs)
            {
                // The asset being sent
                byte[] output_asset = output.AssetId;

                // The Address where the asset is being sent to
                byte[] output_script_hash = output.ScriptHash;

                // How much of the asset is being sent
                long output_value = output.Value;
            }
        }
    }
}
