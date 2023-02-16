using Fluxor;

namespace DIFluxor.Store;

public static class CounterReducers
{
    [ReducerMethod]
    public static CounterState Increment(CounterState state, CounterIncrementAction action)
    {
        Console.WriteLine("Reduced");
        return new CounterState(state.Counter + 1);
    }
}