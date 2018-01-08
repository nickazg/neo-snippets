# Basics - For Neo Smart Contracts

This is a general overview for Developing NEO smart contracts. Outlining the Dos and Don't. The common gotchas, and anything general.

# Smart Contract Lanuages 
- **C#** (Default)
- **Python** (neo-python)


This section contains a [basic SC Template](./csharp-basics/BasicTemplate.cs)
 to get things going, Preview below:

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